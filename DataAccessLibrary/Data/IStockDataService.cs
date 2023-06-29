using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IStockDataService
	{
		Task CreateStockItem(IStockItemModel stockItem);
		Task<List<IStockItemModel>> ReadAllStockItems();
		Task<List<IStockItemModel>> ReadLowStockItems();
	}
}