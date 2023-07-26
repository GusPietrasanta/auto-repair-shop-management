using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface ICustomerDataService
	{
		Task<int> CreateCustomer(ICustomerModel customer);
		Task DeleteCustomerById(int id);
		Task<List<ICustomerModel>> GetCustomersListForSearchBar(string searchTerm);
		Task<List<ICustomerModel>> ReadAllCustomers();
		Task<ICustomerModel> ReadCustomerById(int id);
		Task UpdateCustomer(ICustomerModel customer);
	}
}