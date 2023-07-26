namespace DataAccessLibrary.Models
{
	public interface IVehicleModel
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string NumberPlate { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
		public string Vin { get; set; }
		public string FuelType { get; set; }
		public string TransmissionType { get; set; }
		public string EngineDescription { get; set; }
		public string BodyType { get; set; }
		public string Cylinders { get; set; }
		public string SizeLitres { get; set; }
		public DateTime FirstVisit { get; set; }
	}
}