using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class DashboardReportModel : IDashboardReportModel
	{
		public int ID { get; set; }
		public DateTime TimeFinished { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NumberPlate { get; set; }
		public string UserName { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
	}
}
