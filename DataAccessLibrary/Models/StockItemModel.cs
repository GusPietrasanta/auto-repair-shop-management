namespace DataAccessLibrary.Models
{
	public class StockItemModel : IStockItemModel
	{
		public int Id { get; set; }
		public string ItemName { get; set; }
		public decimal Quantity { get; set; }
		public string Unit { get; set; }
		public decimal AlarmMinimum { get; set; }
	}
}
