namespace DataAccessLibrary.Models
{
	public interface ICustomerModel
	{
		string Address { get; set; }
		string Email { get; set; }
		string FirstName { get; set; }
		int ID { get; set; }
		string LastName { get; set; }
		string PhoneNumber { get; set; }
	}
}