using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UISearchReportsByLastNameAndRego : ISearchReportsByLastNameAndRego
	{
		[Required]
		public string LastName { get; set; }
		[Required]
		public string NumberPlate { get; set; }
	}
}
