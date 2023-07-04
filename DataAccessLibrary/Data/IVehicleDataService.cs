using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IVehicleDataService
	{
		Task<int> CreateVehicle(IVehicleModel vehicle);
		Task<List<IVehicleModel>> GetAllVehicles();
		Task<IVehicleModel> GetVehicleDetailsByID(int ID);
        Task<List<IVehicleModel>> GetVehiclesByCustomerID(int CustomerID);
        Task SaveVehicleFirstVisit(int ID, DateTime firstVisitDateTime);
		Task UpdateVehicle(IVehicleModel vehicle);
	}
}