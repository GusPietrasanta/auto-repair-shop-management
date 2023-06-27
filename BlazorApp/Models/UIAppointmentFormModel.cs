using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UIAppointmentFormModel
	{
		[Required]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid First Name Length.")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Invalid Last Name Length.")]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string Address { get; set; }

		[Required]
		public string NumberPlate { get; set; }

		[Required]
		[ValidateDateRange]
		public DateTime Date { get; set; } = DateTime.Now.AddDays(1);
	}

	public class ValidateDateRange : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			DateTime dt = (DateTime)value;

			if (dt.ToString("ddd") == "Sat" || dt.ToString("ddd") == "Sun")
			{
				return new ValidationResult("Date must be Monday to Friday.");
			}
			else if (dt <= DateTime.Now)
			{
				return new ValidationResult("Date must be after today.");
			}
			else
			{
				return ValidationResult.Success;
			}
		}
	}
}
