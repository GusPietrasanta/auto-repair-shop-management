namespace DataAccessLibrary.Models
{
	public class MakeCountDataModel : IMakeCountDataModel
	{
		public string Make { get; set; }

		public int VehicleCount { get; set; }
	}
}
