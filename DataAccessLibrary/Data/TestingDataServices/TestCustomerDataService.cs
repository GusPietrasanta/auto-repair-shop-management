using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public class TestCustomerDataService : ICustomerDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public TestCustomerDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateCustomer(ICustomerModel customer)
		{
			var c = new
			{
				customer.FirstName,
				customer.LastName,
				customer.Email,
				customer.PhoneNumber,
				customer.Address
			};

			var newCustomerId = await _dataAccess.LoadData<CustomerModel, dynamic>("dbo.spCustomer_Create", c, "TestSqlDb");

			return newCustomerId.FirstOrDefault()!.Id;
		}

		public async Task<List<ICustomerModel>> ReadAllCustomers()
		{
			var customers = await _dataAccess.LoadData<CustomerModel, dynamic>("dbo.spCustomer_ReadAll", new { }, "TestSqlDb");

			return customers.ToList<ICustomerModel>();
		}

		public async Task<ICustomerModel> ReadCustomerById(int id)
		{
			var customers = await _dataAccess.LoadData<CustomerModel, dynamic>("dbo.spCustomer_Read_By_Id", new { ID = id }, "TestSqlDb");

			return customers.ToList<ICustomerModel>().FirstOrDefault();
		}

		public async Task DeleteCustomerById(int id)
		{
			await _dataAccess.SaveData<dynamic>("spCustomer_DeleteByID", new { ID = id }, "TestSqlDb");
		}

		public async Task UpdateCustomer(ICustomerModel customer)
		{
			await _dataAccess.SaveData("spCustomer_Update", customer, "TestSqlDb");
		}

		//spCustomer_Read_SearchBar
		public async Task<List<ICustomerModel>> GetCustomersListForSearchBar(string searchTerm)
		{
			var customers = await _dataAccess.LoadData<CustomerModel, dynamic>("spCustomer_Read_SearchBar", new { SearchTerm = searchTerm }, "TestSqlDb");

			return customers.ToList<ICustomerModel>();
		}
	}
}
