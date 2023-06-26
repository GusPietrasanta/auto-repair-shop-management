using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class StockItemModel : IStockItemModel
	{
		public int ID { get; set; }
		public string ItemName { get; set; }
		public decimal Quantity { get; set; }
		public string Unit { get; set; }
		public decimal AlarmMinimum { get; set; }
	}
}
