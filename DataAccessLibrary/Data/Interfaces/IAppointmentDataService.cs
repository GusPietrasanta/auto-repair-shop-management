using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IAppointmentDataService
	{
		Task AssignJobCardById(int appointmentId, int mechanicId);
		Task<int> CreateAppointment(IAppointmentModel appointment);
		Task DeleteAppointmentById(int id);
		Task<int> GetTodayAppointmentsCountByUserName(string userName);
		Task<List<IAppointmentModel>> ReadAllAppointments();
		Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailed();
		Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailedByUserName(string userName);
		Task<List<IDetailedAppointment>> ReadTodayAppointmentsDetailed();
		Task SetAppointmentAsCompletedById(int id);
		Task<List<IDetailedAppointment>> ReadAllIncompleteAppointmentsDetailed();
	}
}