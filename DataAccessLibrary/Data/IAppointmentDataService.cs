using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IAppointmentDataService
	{
		Task AssignJobCardByID(int appointmentId, int mechanicId);
		Task<int> CreateAppointment(IAppointmentModel appointment);
		Task DeleteAppointmentByID(int id);
		Task<int> GetTodayAppointmentsCountByUserName(string userName);
		Task<List<IAppointmentModel>> ReadAllAppointments();
		Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailed();
		Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailedByUserName(string userName);
		Task<List<IDetailedAppointment>> ReadTodayAppointmentsDetailed();
		Task SetAppointmentAsCompletedByID(int ID);
	}
}