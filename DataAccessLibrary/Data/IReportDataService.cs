using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IReportDataService
	{
		Task CreateReport(IReportModel newReport);
		Task<IFullReportModel> GetFullReportFromID(int reportID);
		Task<int> GetReportIDFromAppointmentIDAsync(int appointmentID);
		Task<List<IDashboardReportModel>> SearchAllReporstDashboard();
		Task<List<IFullReportModel>> SearchAllReports();
		Task<List<IFullReportModel>> SearchReports(ISearchReporstByLastNameAndRego searchDetails);
	}
}