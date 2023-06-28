using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
	public class MechanicSessionData : IMechanicSessionData
	{
		private IDetailedAppointment appointmentToWork;

		public void SetAppointmentToWorkOn(IDetailedAppointment newAppointmentToWork)
		{
			appointmentToWork = newAppointmentToWork;
		}
		public IDetailedAppointment GetAppointmentToWorkOn()
		{
			return appointmentToWork;
		}
	}
}
