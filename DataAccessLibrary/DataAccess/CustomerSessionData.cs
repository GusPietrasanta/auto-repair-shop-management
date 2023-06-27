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
