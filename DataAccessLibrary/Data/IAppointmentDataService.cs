using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IAppointmentDataService
	{
		Task<int> CreateAppointment(IAppointmentModel appointment);
	}
}