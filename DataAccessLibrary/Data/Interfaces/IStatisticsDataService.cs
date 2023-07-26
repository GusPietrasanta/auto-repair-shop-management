using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IStatisticsDataService
	{
		Task<List<IImmediateAttentionDataModel>> GetImmediateAttentionStatistics();
		Task<List<IMakeCountDataModel>> GetMakeCountStatistics();
	}
}