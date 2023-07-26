using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class StatisticsDataService : IStatisticsDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public StatisticsDataService(ISqlDataAccess dataAccess)
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
