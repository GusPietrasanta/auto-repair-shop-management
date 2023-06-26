using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UIStockItemModel : IStockItemModel
	{
		public int ID { get; set; }
		[Required]
		public string ItemName { get; set; }
		[Required]
		public decimal Quantity { get; set; }
		[Required]
		public string Unit { get; set; }
		[Required]
		public decimal AlarmMinimum { get; set; }
	}
}
