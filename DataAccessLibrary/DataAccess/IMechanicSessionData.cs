using DataAccessLibrary.Models;

namespace DataAccessLibrary.DataAccess
{
	public interface IMechanicSessionData
	{
		IDetailedAppointment GetAppointmentToWorkOn();
		void SetAppointmentToWorkOn(IDetailedAppointment newAppointmentToWork);
	}
}