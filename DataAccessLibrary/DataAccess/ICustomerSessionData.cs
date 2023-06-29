using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
	public interface ICustomerSessionData
	{
		DateTime GetAppointmentDate();
		int GetAppointmentID();
		string GetAppointmentNumberPlate();
		IFullReportModel GetReport();
		List<IFullReportModel> GetReports();
		bool GetSearchButtonClicked();
		ISearchReporstByLastNameAndRego GetSearchDetails();
		void SetAppointmentDateTime(DateTime newAppointmentDate);
		void SetAppointmentID(int newAppointmentID);
		void SetAppointmentNumberPlate(string newAppointmentNumberPlate);
		void SetReport(IFullReportModel newReport);
		void SetReports(List<IFullReportModel> newReports);
		void SetSearchButtonClickedToTrue();
		void SetSearchDetails(ISearchReporstByLastNameAndRego newDetails);
	}
}