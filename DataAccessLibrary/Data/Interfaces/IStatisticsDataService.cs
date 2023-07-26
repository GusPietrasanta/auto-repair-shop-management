using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IStatisticsDataService
	{
		Task<List<IImmediateAttentionDataModel>> GetImmediateAttentionStatistics();
		Task<List<IMakeCountDataModel>> GetMakeCountStatistics();
	}
}