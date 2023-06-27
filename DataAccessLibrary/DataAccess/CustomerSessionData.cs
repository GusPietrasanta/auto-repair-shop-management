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

		public int GetAppointmentID()
		{
			return appointmentID;
		}
		public void SetAppointmentID(int newAppointmentID)
		{
			appointmentID = newAppointmentID;
		}
	}
}
