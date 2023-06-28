using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IReportDataService
	{
		Task CreateReport(IReportModel newReport);
	}
}