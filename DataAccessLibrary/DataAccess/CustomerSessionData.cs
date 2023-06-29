using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
	public class CustomerSessionData : ICustomerSessionData
	{
		private int appointmentID;
		private string appointmentNumberPlate;
		private DateTime appointmentDate;
		private IFullReportModel sessionReport;
		private List<IFullReportModel> allSessionReports;

		private bool wasSearchButtonClicked = false;

		private ISearchReporstByLastNameAndRego searchDetails;


		public void SetSearchDetails(ISearchReporstByLastNameAndRego newDetails)
		{
			searchDetails = newDetails;
		}

		public ISearchReporstByLastNameAndRego GetSearchDetails()
		{
			return searchDetails;
		}

		public void SetSearchButtonClickedToTrue()
		{
			wasSearchButtonClicked = true;
		}
		
		public bool GetSearchButtonClicked()
		{
			return wasSearchButtonClicked;
		}


		public List<IFullReportModel> GetReports()
		{
			return allSessionReports;
		}

		public void SetReports(List<IFullReportModel> newReports)
		{
			allSessionReports = newReports;
		}

		public IFullReportModel GetReport()
		{
			return sessionReport;
		}

		public void SetReport(IFullReportModel newReport)
		{
			sessionReport = newReport;
		}

        public int GetAppointmentID()
		{
			return appointmentID;
		}
		public void SetAppointmentID(int newAppointmentID)
		{
			appointmentID = newAppointmentID;
		}
		public string GetAppointmentNumberPlate()
		{
			return appointmentNumberPlate;
		}
		public void SetAppointmentNumberPlate(string newAppointmentNumberPlate)
		{
			appointmentNumberPlate = newAppointmentNumberPlate;
		}
		public DateTime GetAppointmentDate()
		{
			return appointmentDate;
		}
		public void SetAppointmentDateTime(DateTime newAppointmentDate)
		{
			appointmentDate = newAppointmentDate;
		}
	}
}
