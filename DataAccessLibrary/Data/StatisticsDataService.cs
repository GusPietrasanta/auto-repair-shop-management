using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class StatisticsDataService : IStatisticsDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public StatisticsDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<List<IMakeCountDataModel>> GetMakeCountStatistics()
		{
			var makeCountData = await _dataAccess.LoadData<MakeCountDataModel, dynamic>("spStatisticsGetVehicleCountByBrand", new { }, "SQLDB");

			return makeCountData.ToList<IMakeCountDataModel>();
		}

		public async Task<List<IImmediateAttentionDataModel>> GetImmediateAttentionStatistics()
		{
			var immediateAttentionItems = await _dataAccess.LoadData<ImmediateAttentionDataModel, dynamic>("spStatisticsGetTopImmediateAttentionItems", new { }, "SQLDB");

			return immediateAttentionItems.ToList<IImmediateAttentionDataModel>();
		}
	}
}
