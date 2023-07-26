using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IReportDataService
	{
		Task ArchiveInspection(int id);
		Task CreateReport(IReportModel newReport);
		Task<IFullReportModel> GetFullReportFromId(int reportId);
		Task<int> GetReportIdFromAppointmentIdAsync(int appointmentId);
		Task<List<IReportModel>> GetReportsByVehicleId(int vehicleId);
		Task<List<IDashboardReportModel>> SearchAllReportsDashboard();
		Task<List<IFullReportModel>> SearchAllReports();
		Task<List<IFullReportModel>> SearchReports(ISearchReporstByLastNameAndRego searchDetails);
		Task<List<IDashboardReportModel>> SearchAllReportsDashboardNonArchived();
	}
}