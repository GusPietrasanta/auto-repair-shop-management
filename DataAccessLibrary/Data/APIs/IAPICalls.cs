using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.APIs
{
	public interface IAPICalls
	{
		IVehicleModel GetVehicleDetails(string numberPlate);
	}
}