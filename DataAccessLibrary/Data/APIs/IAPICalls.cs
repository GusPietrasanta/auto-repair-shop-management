using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.APIs
{
	public interface IApiCalls
	{
		IVehicleModel GetVehicleDetails(string numberPlate);
	}
}