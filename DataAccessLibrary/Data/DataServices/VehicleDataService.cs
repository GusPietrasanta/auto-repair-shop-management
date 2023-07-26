using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class VehicleDataService : IVehicleDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public VehicleDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<int> CreateVehicle(IVehicleModel vehicle)
		{
			var v = new
			{
				CustomerID = vehicle.CustomerId,
				vehicle.NumberPlate,
				vehicle.Make,
				vehicle.Model,
				vehicle.Year,
				VIN = vehicle.Vin,
				vehicle.FuelType,
				vehicle.TransmissionType,
				vehicle.EngineDescription,
				vehicle.BodyType,
				vehicle.Cylinders,
				vehicle.SizeLitres
			};

			var newVehicleId = await _dataAccess.LoadData<VehicleModel, dynamic>("dbo.spVehicle_Create", v, "SQLDB");

			return newVehicleId.FirstOrDefault()!.Id;
		}

		public async Task<IVehicleModel> GetVehicleDetailsById(int id)
		{
			var vehicleDetails = await _dataAccess.LoadData<VehicleModel, dynamic>("dbo.spVehicle_ReadByID", new { ID = id }, "SQLDB");

			return vehicleDetails.FirstOrDefault();
		}

		public async Task SaveVehicleFirstVisit(int id, DateTime firstVisitDateTime)
		{
			var p = new
			{
				ID = id,
				FirstVisit = firstVisitDateTime
			};

			await _dataAccess.SaveData<dynamic>("spVehicle_UpdateFirstVisitByID", p, "SQLDB");
		}

		public async Task<List<IVehicleModel>> GetVehiclesByCustomerId(int customerId)
		{

			var vehicles = await _dataAccess.LoadData<VehicleModel, dynamic>("spVehicle_ReadByCustomerID", new { CustomerID = customerId }, "SQLDB");

			return vehicles.ToList<IVehicleModel>();

		}

		public async Task UpdateVehicle(IVehicleModel vehicle)
		{
			var v = new
			{
				ID = vehicle.Id,
				vehicle.NumberPlate,
				vehicle.Make,
				vehicle.Model,
				vehicle.Year,
				VIN = vehicle.Vin,
				vehicle.FuelType,
				vehicle.TransmissionType,
				vehicle.EngineDescription,
				vehicle.BodyType,
				vehicle.Cylinders,
				vehicle.SizeLitres,
				vehicle.FirstVisit
			};

			await _dataAccess.SaveData<dynamic>("dbo.spVehicle_Update", v, "SQLDB");
		}

		public async Task<List<IVehicleModel>> GetAllVehicles()
		{

			var vehicles = await _dataAccess.LoadData<VehicleModel, dynamic>("spVehicle_ReadAll", new { }, "SQLDB");

			return vehicles.ToList<IVehicleModel>();

		}

        public async Task<List<IVehicleModel>> GetVehiclesListForSearchBar(string searchTerm)
		{
            var vehicles = await _dataAccess.LoadData<VehicleModel, dynamic>("spVehicle_Read_SearchBar", new { SearchTerm = searchTerm }, "SQLDB");

            return vehicles.ToList<IVehicleModel>();
        }
	}
}
