using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IVehicleDataService
	{
		Task<int> CreateVehicle(IVehicleModel vehicle);
		Task<IVehicleModel> GetVehicleDetailsByID(int ID);
		Task SaveVehicleFirstVisit(int ID, DateTime firstVisitDateTime);
	}
}