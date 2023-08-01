using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class AppointmentDataService : IAppointmentDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public AppointmentDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateAppointment(IAppointmentModel appointment)
		{
			var p = new
			{
				CustomerID = appointment.CustomerId,
				VehicleID = appointment.VehicleId,
				appointment.Date
			};

			var newAppointmentId = await _dataAccess.LoadData<AppointmentModel, dynamic>("dbo.spAppointment_Create", p, "SQLDB");

			return newAppointmentId.FirstOrDefault()!.Id;
		}

		public async Task<List<IAppointmentModel>> ReadAllAppointments()
		{
			var appointments = await _dataAccess.LoadData<AppointmentModel, dynamic>("dbo.spAppointment_ReadAll", new { }, "SQLDB");

			return appointments.ToList<IAppointmentModel>();
		}

		public async Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailed()
		{
			var detailedAppointments = await _dataAccess.LoadData<DetailedAppointment, dynamic>("dbo.spAppointment_Details_ReadAll", new { }, "SQLDB");

			return detailedAppointments.ToList<IDetailedAppointment>();
		}
		
		public async Task<List<IDetailedAppointment>> ReadAllIncompleteAppointmentsDetailed()
		{
			var detailedAppointments = await _dataAccess.LoadData<DetailedAppointment, dynamic>("dbo.spAppointment_Details_ReadAll_Incomplete", new { }, "SQLDB");

			return detailedAppointments.ToList<IDetailedAppointment>();
		}
		
		public async Task<List<IDetailedAppointment>> ReadAllAppointmentsDetailedByUserName(string userName)
		{
			var detailedAppointmentsByUserName = await _dataAccess.LoadData<DetailedAppointment, dynamic>("dbo.spAppointment_Details_ReadByUserName", new { UserName = userName }, "SQLDB");

			return detailedAppointmentsByUserName.ToList<IDetailedAppointment>();
		}

		public async Task DeleteAppointmentById(int id)
		{
			await _dataAccess.SaveData("spAppointment_DeleteById", new { ID = id }, "SQLDB");
		}

		public async Task AssignJobCardById(int appointmentId, int mechanicId)
		{
			await _dataAccess.SaveData("spAppointment_AssignMechanicByID", new { AppointmentID = appointmentId, MechanicID = mechanicId }, "SQLDB");
		}

		public async Task SetAppointmentAsCompletedById(int id)
		{
			await _dataAccess.SaveData("spAppointment_UpdateCompletedByID", new { ID = id }, "SQLDB");
		}

		public async Task<int> GetTodayAppointmentsCountByUserName(string userName)
		{
			var appointmentCount = await _dataAccess.LoadData<int, dynamic>("dbo.spAppointment_CountByMechanicToday", new { UserName = userName, Date = DateTime.Today }, "SQLDB");

			return appointmentCount.FirstOrDefault();
		}

		public async Task<List<IDetailedAppointment>> ReadTodayAppointmentsDetailed()
		{
			var todayDetailedAppointments = await _dataAccess.LoadData<DetailedAppointment, dynamic>("dbo.spAppointment_Today_Details", new { DateTime.Today }, "SQLDB");

			return todayDetailedAppointments.ToList<IDetailedAppointment>();
		}
	}
}
