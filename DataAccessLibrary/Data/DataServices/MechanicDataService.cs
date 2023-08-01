using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
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

		public async Task<int> GetMechanicIdByUserName(string userName)
		{
			var mechanicId = await _dataAccess.LoadData<int, dynamic>("spMechanic_GetIdByUserName",
				new { FirstName = userName }, "SQLDB");

			return mechanicId.FirstOrDefault();
		}
	}
}
