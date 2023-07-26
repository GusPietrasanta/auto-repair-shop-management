using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UIMessageModel : IMessageModel
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		[Required]
		[MinLength(10)]
		public string Content { get; set; }
		public DateTime PostedOn { get; set; }

		[Required]
		public string Tag { get; set; }
	}
}
