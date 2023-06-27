using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UICustomerModel : ICustomerModel
	{
		public int ID { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		[Required]
		public string Address { get; set; }
	}
}
