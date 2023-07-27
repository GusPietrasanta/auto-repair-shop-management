using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class StockDataService : IStockDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public StockDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateStockItem(IStockItemModel stockItem)
		{
			var i = new
			{
				stockItem.ItemName,
				stockItem.Quantity,
				stockItem.Unit,
				stockItem.AlarmMinimum
			};

			var item = await _dataAccess.LoadData<StockItemModel, dynamic>("dbo.spStock_Create", i, "SQLDB");

			return item.FirstOrDefault()!.Id;
		}

		public async Task<List<IStockItemModel>> ReadAllStockItems()
		{
			var stockItems = await _dataAccess.LoadData<StockItemModel, dynamic>("dbo.spStock_ReadAll", new { }, "SQLDB");

			return stockItems.ToList<IStockItemModel>();
		}

		public async Task<List<IStockItemModel>> ReadLowStockItems()
		{
			var lowStockItems = await _dataAccess.LoadData<StockItemModel, dynamic>("dbo.spStock_ReadLows", new { }, "SQLDB");

			return lowStockItems.ToList<IStockItemModel>();
		}

        public async Task<List<IStockItemModel>> GetStockListForSearchBar(string searchTerm)
        {
            var stockItems = await _dataAccess.LoadData<StockItemModel, dynamic>("dbo.spStock_Read_SearchBar", new { SearchTerm = searchTerm }, "SQLDB");

            return stockItems.ToList<IStockItemModel>();
        }

		public async Task<IStockItemModel> GetStockItemById(int id)
		{
			var stockItem = await _dataAccess.LoadData<StockItemModel, dynamic>("dbo.spStock_Read_ByID", new { ID = id }, "SQLDB");

			return stockItem.FirstOrDefault();
        }

		public async Task UpdateItemById(IStockItemModel item)
		{
			var i = new
			{
				ID = item.Id,
				item.ItemName,
				item.Quantity,
				item.Unit,
				item.AlarmMinimum
			};

			await _dataAccess.SaveData<dynamic>("spStock_Update_ByID", i, "SQLDB");
		}

		public async Task DeleteItemById(int itemId)
		{
			await _dataAccess.SaveData<dynamic>("spStock_Delete", new {ID = itemId}, "SQLDB");
		}
	}
}
