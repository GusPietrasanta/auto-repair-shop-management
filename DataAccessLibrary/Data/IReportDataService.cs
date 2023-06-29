using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IReportDataService
	{
		Task CreateReport(IReportModel newReport);
		Task<List<IFullReportModel>> SearchReports(ISearchReporstByLastNameAndRego searchDetails);
	}
}