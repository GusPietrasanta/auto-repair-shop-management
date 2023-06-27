namespace DataAccessLibrary.Models
{
	public interface IVehicleModel
	{
		int CustomerID { get; set; }
		string Cylinders { get; set; }
		DateTime FirstVisit { get; set; }
		string FuelType { get; set; }
		int ID { get; set; }
		string Make { get; set; }
		string Model { get; set; }
		string NumberPlate { get; set; }
		string SizeLitres { get; set; }
		string TransmissionType { get; set; }
		string VIN { get; set; }
		string Year { get; set; }
	}
}