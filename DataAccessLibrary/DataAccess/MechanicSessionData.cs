using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
	public class MechanicSessionData : IMechanicSessionData
	{
		private IDetailedAppointment _appointmentToWork;

		public void SetAppointmentToWorkOn(IDetailedAppointment newAppointmentToWork)
		{
			_appointmentToWork = newAppointmentToWork;
		}
		public IDetailedAppointment GetAppointmentToWorkOn()
		{
			return _appointmentToWork;
		}
	}
}
