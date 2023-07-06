using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface ICustomerDataService
	{
		Task<int> CreateCustomer(ICustomerModel customer);
		Task DeleteCustomerByID(int id);
		Task<List<ICustomerModel>> GetCustomersListForSearchBar(string searchTerm);
		Task<List<ICustomerModel>> ReadAllCustomers();
		Task<ICustomerModel> ReadCustomerByID(int id);
		Task UpdateCustomer(ICustomerModel customer);
	}
}