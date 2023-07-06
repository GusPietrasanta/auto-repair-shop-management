﻿using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class StockDataService : IStockDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public StockDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task CreateStockItem(IStockItemModel stockItem)
		{
			var i = new
			{
				stockItem.ItemName,
				stockItem.Quantity,
				stockItem.Unit,
				stockItem.AlarmMinimum
			};

			await _dataAccess.SaveData("dbo.spStock_Create", i, "SQLDB");
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
    }
}
