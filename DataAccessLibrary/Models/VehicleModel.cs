using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
	public class VehicleModel : IVehicleModel
	{
		public int ID { get; set; }
		public int CustomerID { get; set; }
		public string NumberPlate { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string VIN { get; set; }
		public string FuelType { get; set; }
		public string TransmissionType { get; set; }
		public string EngineDescription { get; set; }
		public string BodyType { get; set; }
		public string Cylinders { get; set; }
		public string SizeLitres { get; set; }
		public DateTime FirstVisit { get; set; }
	}
}
