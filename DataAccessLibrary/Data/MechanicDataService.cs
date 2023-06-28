using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class MechanicDataService : IMechanicDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public MechanicDataService(ISQLDataAccess dataAccess)
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
