using System.Text.Json;
using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.Data.TestingDataServices;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RepairShopTests;

[TestFixture]
public class DbTests
{
    private ICustomerModel _testCustomer = null!;
    private ICustomerDataService _customerData = null!;
    private int _newCustomerId;

    [OneTimeSetUp]
    public void Setup()
    {
        // Setting up necessary dependencies to test DB
        var services = new ServiceCollection();
        services.AddTransient<IConfiguration>(_ =>
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddEnvironmentVariables();
            return configurationBuilder.Build();
        });
        services.AddScoped<ISqlDataAccess, SqlDataAccess>();
        services.AddScoped<ICustomerDataService, TestCustomerDataService>();
        var serviceProvider = services.BuildServiceProvider();

        _customerData = serviceProvider.GetService<ICustomerDataService>()!;
        
        _testCustomer = new CustomerModel
        {
            FirstName = "Test",
            LastName = "User",
            Email = "user@test.com",
            PhoneNumber = "999-999-999",
            Address = "123 Integration Street, Testingham"
        };
    }

    // Create a user
    [Test]
    public async Task CreateUser()
    {
        _newCustomerId = await _customerData.CreateCustomer(_testCustomer);
        
        _testCustomer.Id = _newCustomerId;

        Assert.NotNull(_testCustomer.Id);
    }
    
    // Retrieve user by Id and compare with the original one
    [Test]
    public async Task RetrieveUser()
    {
        var userToCompare = await _customerData.ReadCustomerById(_newCustomerId);

        // Serialise to compare attributes
        Assert.That(JsonSerializer.Serialize(userToCompare), Is.EqualTo(JsonSerializer.Serialize(_testCustomer)));
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        // _customerData.DeleteCustomerById(_testCustomer.Id);
    }
}