using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface ICustomerDataService
	{
		Task<ICustomerModel> CreateCustomer(ICustomerModel customer);
		Task<List<ICustomerModel>> ReadAllCustomers();
	}
}