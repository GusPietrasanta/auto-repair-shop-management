using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class ReportDataService : IReportDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public ReportDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}
		public async Task CreateReport(IReportModel newReport)
		{
			await _dataAccess.SaveData<dynamic>("spReport_Create", newReport, "SQLDB");
		}
		public async Task<List<IFullReportModel>> SearchReports(ISearchReportsByLastNameAndRego searchDetails)
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_SearchByLastName_Rego", searchDetails, "SQLDB");

			return results.ToList<IFullReportModel>();
		}
		public async Task<List<IFullReportModel>> SearchAllReports()
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_SearchAll", new { }, "SQLDB");

			return results.ToList<IFullReportModel>();
		}

		public async Task<List<IDashboardReportModel>> SearchActiveReportsDashboard()
		{
			var results = await _dataAccess.LoadData<DashboardReportModel, dynamic>("spReport_SearchAllDashboard", new { }, "SQLDB");

			return results.ToList<IDashboardReportModel>();
		}

		public async Task<int> GetReportIdFromAppointmentIdAsync(int appointmentId)
		{
			var results = await _dataAccess.LoadData<int, dynamic>("spReport_ID_From_AppointmentID", new { AppointmentID = appointmentId }, "SQLDB");

			return results.ToList().FirstOrDefault();
		}

		public async Task<IFullReportModel> GetFullReportFromId(int reportId)
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_Read_By_ID", new { ID = reportId }, "SQLDB");

			return results.ToList().FirstOrDefault();
		}

		public async Task ArchiveInspection(int id)
		{
			await _dataAccess.SaveData<dynamic>("spReport_Archive", new { ID = id }, "SQLDB");
		}

		public async Task<List<IReportModel>> GetReportsByVehicleId(int vehicleId)
		{
			var results = await _dataAccess.LoadData<ReportModel, dynamic>("spReport_Read_By_VehicleID", new { VehicleID = vehicleId }, "SQLDB");

			return results.ToList<IReportModel>();
		}

		public async Task<List<IDashboardReportModel>> SearchAllReportsDashboard()
		{
			var results = await _dataAccess.LoadData<DashboardReportModel, dynamic>("spReport_SearchAllDashboardNonArchived", new { }, "SQLDB");

			return results.ToList<IDashboardReportModel>();
		}
		public async Task<List<IDashboardReportModel>> GetReportsPagination(int offset, int fetch)
		{
			var results = await _dataAccess.LoadData<DashboardReportModel, dynamic>("spReport_Pagination", new { Offset = offset, Fetch = fetch }, "SQLDB");

			return results.ToList<IDashboardReportModel>();
		}

		public async Task<int> GetReportsCount()
		{
			var count = await _dataAccess.LoadData<int, dynamic>("spReport_GetReportsCount", new { }, "SQLDB");

			return count.FirstOrDefault();
		}
	}
}
