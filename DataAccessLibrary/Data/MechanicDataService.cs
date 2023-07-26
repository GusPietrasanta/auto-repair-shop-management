using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public class MechanicDataService : IMechanicDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public MechanicDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task<List<IMechanicBasicModel>> ReadAllMechanicsBasic()
		{
			var mechanicsBasic = await _dataAccess.LoadData<MechanicBasicModel, dynamic>("spMechanic_ReadAllBasic", new { }, "SQLDB");

			return mechanicsBasic.ToList<IMechanicBasicModel>();
		}
	}
}
