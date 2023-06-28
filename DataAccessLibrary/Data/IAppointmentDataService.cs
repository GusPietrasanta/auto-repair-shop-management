using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IAppointmentDataService
	{
		Task AssignJobCardByID(int appointmentId, int mechanicId);
		Task<int> CreateAppointment(IAppointmentModel appointment);
		Task DeleteAppointmentByID(int id);
		Task<List<IAppointmentModel>> ReadAllAppointments();
		Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailed();
	}
}