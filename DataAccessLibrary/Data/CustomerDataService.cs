using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class CustomerDataService : ICustomerDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public CustomerDataService(ISQLDataAccess dataAccess)
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

			var newCustomerId = await _dataAccess.LoadData<CustomerModel, dynamic>("dbo.spCustomer_Create", c, "SQLDB");

			return newCustomerId.FirstOrDefault().ID;
		}

		public async Task<List<ICustomerModel>> ReadAllCustomers()
		{
			var customers = await _dataAccess.LoadData<CustomerModel, dynamic>("dbo.spCustomer_ReadAll", new { }, "SQLDB");

			return customers.ToList<ICustomerModel>();
		}
	}
}
