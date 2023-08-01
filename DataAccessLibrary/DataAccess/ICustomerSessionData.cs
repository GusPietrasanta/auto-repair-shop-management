using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
	public interface ICustomerSessionData
	{
		DateTime GetAppointmentDate();
		int GetAppointmentId();
		string GetAppointmentNumberPlate();
		IFullReportModel GetReport();
		List<IFullReportModel> GetReports();
		bool GetSearchButtonClicked();
		ISearchReportsByLastNameAndRego GetSearchDetails();
		void SetAppointmentDateTime(DateTime newAppointmentDate);
		void SetAppointmentId(int newAppointmentId);
		void SetAppointmentNumberPlate(string newAppointmentNumberPlate);
		void SetReport(IFullReportModel newReport);
		void SetReports(List<IFullReportModel> newReports);
		void SetSearchButtonClickedToTrue();
		void SetSearchDetails(ISearchReportsByLastNameAndRego newDetails);
	}
}