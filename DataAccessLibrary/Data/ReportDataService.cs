using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class ReportDataService : IReportDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public ReportDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}
		public async Task CreateReport(IReportModel newReport)
		{
			await _dataAccess.SaveData<dynamic>("spReport_Create", newReport, "SQLDB");
		}
		public async Task<List<IFullReportModel>> SearchReports(ISearchReporstByLastNameAndRego searchDetails)
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_SearchByLastName_Rego", searchDetails, "SQLDB");

			return results.ToList<IFullReportModel>();
		}
		public async Task<List<IFullReportModel>> SearchAllReports()
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_SearchAll", new { }, "SQLDB");

			return results.ToList<IFullReportModel>();
		}

		public async Task<List<IDashboardReportModel>> SearchAllReporstDashboard()
		{
			var results = await _dataAccess.LoadData<DashboardReportModel, dynamic>("spReport_SearchAllDashboard", new { }, "SQLDB");

			return results.ToList<IDashboardReportModel>();
		}

		public async Task<int> GetReportIDFromAppointmentIDAsync(int appointmentID)
		{
			var results = await _dataAccess.LoadData<int, dynamic>("spReport_ID_From_AppointmentID", new { AppointmentID = appointmentID }, "SQLDB");

			return results.ToList().FirstOrDefault();
		}

		public async Task<IFullReportModel> GetFullReportFromID(int reportID)
		{
			var results = await _dataAccess.LoadData<FullReportModel, dynamic>("spReport_Read_By_ID", new { ID = reportID }, "SQLDB");

			return results.ToList().FirstOrDefault();
		}

		public async Task ArchiveInspection(int ID)
		{
			await _dataAccess.SaveData<dynamic>("spReport_Archive", new { ID }, "SQLDB");
		}
	}
}
