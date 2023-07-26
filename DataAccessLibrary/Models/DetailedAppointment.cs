namespace DataAccessLibrary.Models
{
	public class DetailedAppointment : IDetailedAppointment
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool Completed { get; set; }
		public string NumberPlate { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int MechanicId { get; set; }
		public int VehicleId { get; set; }
		public int CustomerId { get; set; }
		public string UserName { get; set; }
	}
}
