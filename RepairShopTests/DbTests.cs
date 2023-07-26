using DataAccessLibrary.Data;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RepairShopTests;

public class DbTests
{
    private ICustomerModel _testCustomer = null!;
    private ICustomerDataService _customerData = null!;

    [SetUp]
    public void Setup()
    {        
        
        // Setting up necessary dependencies to test DB
        var services = new ServiceCollection();
        services.AddTransient<IConfiguration>(sp =>
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

    [Test]
    public async Task CreateUser()
    {
        // Arrange
        int customerId;

        // Act
        customerId = await _customerData.CreateCustomer(_testCustomer);
        _testCustomer.Id = customerId;

        // Assert
        Assert.NotNull(_testCustomer.Id);
    }

    [TearDown]
    public void TearDown()
    {
        // _customerData.DeleteCustomerById(_testCustomer.Id);
    }
}