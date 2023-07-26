namespace DataAccessLibrary.Models
{
	public interface IStockItemModel
	{
		decimal AlarmMinimum { get; set; }
		int Id { get; set; }
		string ItemName { get; set; }
		decimal Quantity { get; set; }
		string Unit { get; set; }
	}
}