using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IStockDataService
	{
		Task<int> CreateStockItem(IStockItemModel stockItem);
		Task DeleteItemById(int itemId);
		Task<IStockItemModel> GetStockItemById(int id);
        Task<List<IStockItemModel>> GetStockListForSearchBar(string searchTerm);
        Task<List<IStockItemModel>> ReadAllStockItems();
		Task<List<IStockItemModel>> ReadLowStockItems();
		Task UpdateItemById(IStockItemModel item);
	}
}