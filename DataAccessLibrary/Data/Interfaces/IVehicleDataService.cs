using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IVehicleDataService
	{
		Task<int> CreateVehicle(IVehicleModel vehicle);
		Task<List<IVehicleModel>> GetAllVehicles();
		Task<IVehicleModel> GetVehicleDetailsById(int id);
        Task<List<IVehicleModel>> GetVehiclesByCustomerId(int customerId);
        Task<List<IVehicleModel>> GetVehiclesListForSearchBar(string searchTerm);
        Task SaveVehicleFirstVisit(int id, DateTime firstVisitDateTime);
		Task UpdateVehicle(IVehicleModel vehicle);
	}
}