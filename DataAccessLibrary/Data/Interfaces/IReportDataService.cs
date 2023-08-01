using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IReportDataService
	{
		Task ArchiveInspection(int id);
		Task CreateReport(IReportModel newReport);
		Task<IFullReportModel> GetFullReportFromId(int reportId);
		Task<int> GetReportIdFromAppointmentIdAsync(int appointmentId);
		Task<List<IReportModel>> GetReportsByVehicleId(int vehicleId);
		Task<List<IDashboardReportModel>> SearchActiveReportsDashboard();
		Task<List<IFullReportModel>> SearchAllReports();
		Task<List<IFullReportModel>> SearchReports(ISearchReportsByLastNameAndRego searchDetails);
		Task<List<IDashboardReportModel>> SearchAllReportsDashboard();
		Task<List<IDashboardReportModel>> GetReportsPagination(int offset, int fetch);
		Task<int> GetReportsCount();
	}
}