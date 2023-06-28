﻿using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class AppointmentDataService : IAppointmentDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public AppointmentDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateAppointment(IAppointmentModel appointment)
		{
			var p = new
			{
				appointment.CustomerID,
				appointment.VehicleID,
				appointment.Date
			};

			var newAppointmentId = await _dataAccess.LoadData<AppointmentModel, dynamic>("dbo.spAppointment_Create", p, "SQLDB");

			return newAppointmentId.FirstOrDefault().ID;
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

		public async Task DeleteAppointmentByID(int id)
		{
			await _dataAccess.SaveData("spAppointment_DeleteById", new { ID = id }, "SQLDB");
		}
		public async Task AssignJobCardByID(int appointmentId, int mechanicId)
		{
			await _dataAccess.SaveData("spAppointment_AssignMechanicByID", new { AppointmentID = appointmentId, MechanicID = mechanicId }, "SQLDB");
		}
	}
}
