using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class MakeCountDataModel : IMakeCountDataModel
	{
		public string Make { get; set; }

		public int VehicleCount { get; set; }
	}
}
