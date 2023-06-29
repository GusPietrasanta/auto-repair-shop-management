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
		public async Task<List<IReportModel>> SearchReports(ISearchReporstByLastNameAndRego searchDetails)
		{
			var results = await _dataAccess.LoadData<ReportModel, dynamic>("spReport_SearchByLastName_Rego", searchDetails, "SQLDB");

			return results.ToList<IReportModel>();
		}
	}
}
