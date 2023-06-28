using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class VehicleDataService : IVehicleDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public VehicleDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateVehicle(IVehicleModel vehicle)
		{
			var v = new
			{
				vehicle.CustomerID,
				vehicle.NumberPlate,
				vehicle.Make,
				vehicle.Model,
				vehicle.Year,
				vehicle.VIN,
				vehicle.FuelType,
				vehicle.TransmissionType,
				vehicle.EngineDescription,
				vehicle.BodyType,
				vehicle.Cylinders,
				vehicle.SizeLitres
			};

			var newVehicleId = await _dataAccess.LoadData<VehicleModel, dynamic>("dbo.spVehicle_Create", v, "SQLDB");

			return newVehicleId.FirstOrDefault().ID;
		}

		public async Task<IVehicleModel> GetVehicleDetailsByID(int ID)
		{
			var vehicleDetails = await _dataAccess.LoadData<VehicleModel, dynamic>("dbo.spVehicle_ReadByID", new { ID }, "SQLDB");

			return vehicleDetails.FirstOrDefault();
		}

		public async Task SaveVehicleFirstVisit(int ID, DateTime firstVisitDateTime)
		{
			var p = new
			{
				ID,
				FirstVisit = firstVisitDateTime
			};

			await _dataAccess.SaveData<dynamic>("spVehicle_UpdateFirstVisitByID", p, "SQLDB");
		}
	}
}
