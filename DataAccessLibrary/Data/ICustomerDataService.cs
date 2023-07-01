using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface ICustomerDataService
	{
		Task<int> CreateCustomer(ICustomerModel customer);
		Task<List<ICustomerModel>> ReadAllCustomers();
		Task<ICustomerModel> ReadCustomerByID(int id);
	}
}