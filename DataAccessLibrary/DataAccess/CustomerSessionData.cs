using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
	public class CustomerSessionData : ICustomerSessionData
	{
		private int _appointmentId;
		private string _appointmentNumberPlate;
		private DateTime _appointmentDate;
		private IFullReportModel _sessionReport;
		private List<IFullReportModel> _allSessionReports;

		private bool _wasSearchButtonClicked;

		private ISearchReportsByLastNameAndRego _searchDetails;


		public void SetSearchDetails(ISearchReportsByLastNameAndRego newDetails)
		{
			_searchDetails = newDetails;
		}

		public ISearchReportsByLastNameAndRego GetSearchDetails()
		{
			return _searchDetails;
		}

		public void SetSearchButtonClickedToTrue()
		{
			_wasSearchButtonClicked = true;
		}
		
		public bool GetSearchButtonClicked()
		{
			return _wasSearchButtonClicked;
		}


		public List<IFullReportModel> GetReports()
		{
			return _allSessionReports;
		}

		public void SetReports(List<IFullReportModel> newReports)
		{
			_allSessionReports = newReports;
		}

		public IFullReportModel GetReport()
		{
			return _sessionReport;
		}

		public void SetReport(IFullReportModel newReport)
		{
			_sessionReport = newReport;
		}

        public int GetAppointmentId()
		{
			return _appointmentId;
		}
		public void SetAppointmentId(int newAppointmentId)
		{
			_appointmentId = newAppointmentId;
		}
		public string GetAppointmentNumberPlate()
		{
			return _appointmentNumberPlate;
		}
		public void SetAppointmentNumberPlate(string newAppointmentNumberPlate)
		{
			_appointmentNumberPlate = newAppointmentNumberPlate;
		}
		public DateTime GetAppointmentDate()
		{
			return _appointmentDate;
		}
		public void SetAppointmentDateTime(DateTime newAppointmentDate)
		{
			_appointmentDate = newAppointmentDate;
		}
	}
}
