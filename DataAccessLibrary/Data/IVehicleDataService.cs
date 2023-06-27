using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IVehicleDataService
	{
		Task<int> CreateVehicle(IVehicleModel vehicle);
	}
}