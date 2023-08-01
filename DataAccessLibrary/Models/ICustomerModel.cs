namespace DataAccessLibrary.Models
{
	public interface ICustomerModel
	{
		int Id { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		string Email { get; set; }
		string PhoneNumber { get; set; }
		string Address { get; set; }
	}
}