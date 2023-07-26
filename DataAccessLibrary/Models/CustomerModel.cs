namespace DataAccessLibrary.Models
{
	public class CustomerModel : ICustomerModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Address { get; set; }
	}
}
