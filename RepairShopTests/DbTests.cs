using System.Text.Json;
using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.Data.DataServices;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SqlException = System.Data.SqlClient.SqlException;

namespace RepairShopTests;

[TestFixture]
public class DbTests
{
    private ICustomerModel _testCustomer = null!;
    private IVehicleModel _testVehicle = null!;
    private ICustomerDataService _customerData = null!;
    private IVehicleDataService _vehicleData = null!;
    private int _newCustomerId;
    private int _newVehicleId;

    [OneTimeSetUp]
    public void Setup()
    {
        // Setting up necessary dependencies to test DB
        var services = new ServiceCollection();
        services.AddTransient<IConfiguration>(_ =>
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            // Use the connection string provided in appsettings.json (Test Database)...
            // ...instead of the one stored in environment variables (Production Database)
            configurationBuilder.AddJsonFile(@"appsettings.json");
            return configurationBuilder.Build();
        });
        services.AddScoped<ISqlDataAccess, SqlDataAccess>();
        services.AddScoped<ICustomerDataService, CustomerDataService>();
        services.AddScoped<IVehicleDataService, VehicleDataService>();
        var serviceProvider = services.BuildServiceProvider();

        _customerData = serviceProvider.GetService<ICustomerDataService>()!;
        _vehicleData = serviceProvider.GetService<IVehicleDataService>()!;
        
        _testCustomer = new CustomerModel
        {
            FirstName = "Test",
            LastName = "User",
            Email = "user@test.com",
            PhoneNumber = "999-999-999",
            Address = @"123 Integration Street, Testingham"
        };

        _testVehicle = new VehicleModel
        {
            CustomerId = _newCustomerId,
            Make = "Test Make",
            Model = "Test Model",
            Year = "2000",
            Vin = "TTTT123123TTTT123",
            FuelType = "Diesel",
            TransmissionType = "Auto",
            EngineDescription = "3.0 litre, 6 cyl petrol",
            BodyType = "2 door coupe",
            Cylinders = "6",
            SizeLitres = "3.0"
        };
    }

    // Create a user and assert that an Id was assigned
    [Test, Order(1)]
    public async Task CreateUser_Test()
    {
        _newCustomerId = await _customerData.CreateCustomer(_testCustomer);
        
        _testCustomer.Id = _newCustomerId;

        Assert.NotNull(_testCustomer.Id);
    }
    
    // Retrieve user by Id and compare it with the original one
    [Test, Order(2)]
    public async Task RetrieveUser_Test()
    {
        var userToCompare = await _customerData.ReadCustomerById(_newCustomerId);

        // Serialise to compare attributes
        Assert.That(JsonSerializer.Serialize(userToCompare), Is.EqualTo(JsonSerializer.Serialize(_testCustomer)));
    }

    // Update an user a retrieve it for comparison
    [Test, Order(3)]
    public async Task UpdateUser_Test()
    {
        var user = await _customerData.ReadCustomerById(_newCustomerId);

        user.FirstName = "New First Name";
        user.LastName = "New Last Name";
        user.Address = "123 New Address";
        user.Address = "222-222-222";
        user.Email = "new@email.com";

        await _customerData.UpdateCustomer(user);

        var updatedCustomer = await _customerData.ReadCustomerById(_newCustomerId);
        
        Assert.That(JsonSerializer.Serialize(user), Is.EqualTo(JsonSerializer.Serialize(updatedCustomer)));
    }

    [Test, Order(4)]
    public void RejectNullNumberPlate_Test()
    {
        _testVehicle.CustomerId = _newCustomerId;
        
        Assert.ThrowsAsync<SqlException>(async () => await _vehicleData.CreateVehicle(_testVehicle));
    }

    [Test, Order(5)]
    public async Task CreateVehicle_Test()
    {
        _testVehicle.CustomerId = _newCustomerId;
        
        _testVehicle.NumberPlate = "TESTING";
        
        _newVehicleId = await _vehicleData.CreateVehicle(_testVehicle);

        _testVehicle.Id = _newVehicleId;

        Assert.NotNull(_newVehicleId);
    }
    
    [Test, Order(6)]
    public async Task UpdateVehicle_Test()
    {
        var vehicle = await _vehicleData.GetVehicleDetailsById(_newVehicleId);

        vehicle.Make = "Another Brand";
        vehicle.BodyType = "Another Body Type";
        vehicle.EngineDescription = "Another Engine Description";
        vehicle.FirstVisit = DateTime.Parse("01/01/2000 8:30:00");

        await _vehicleData.UpdateVehicle(vehicle);

        var updatedVehicle = await _vehicleData.GetVehicleDetailsById(_newVehicleId);

        Assert.That(JsonSerializer.Serialize(vehicle), Is.EqualTo(JsonSerializer.Serialize(updatedVehicle)));
    }

    // Delete an user, try to retrieve it again by Id and check that it's in fact null
    [Test, Order(7)]
    public async Task DeleteUser_Test()
    {
        await _customerData.DeleteCustomerById(_newCustomerId);

        var deletedCustomer = await _customerData.ReadCustomerById(_newCustomerId);
        
        Assert.That(deletedCustomer, Is.EqualTo(null));
    }    
    
    // After deleting the user, confirm that the created vehicle doesn't exist anymore
    [Test, Order(8)]
    public async Task DeletedVehicle_Test()
    {
        await _customerData.DeleteCustomerById(_newCustomerId);

        var deletedCustomer = await _customerData.ReadCustomerById(_newCustomerId);
        
        Assert.That(deletedCustomer, Is.EqualTo(null));
    }
}