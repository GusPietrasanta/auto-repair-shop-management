using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.Interfaces
{
	public interface IMechanicDataService
	{
		Task<List<IMechanicBasicModel>> ReadAllMechanicsBasic();
	}
}