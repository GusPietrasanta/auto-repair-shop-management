using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IMechanicDataService
	{
		Task<List<IMechanicBasicModel>> ReadAllMechanicsBasic();
	}
}