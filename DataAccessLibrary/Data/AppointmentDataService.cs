using DataAccessLibrary.DataAccess;
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
	}
}
