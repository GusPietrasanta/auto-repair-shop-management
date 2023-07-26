namespace DataAccessLibrary.Models
{
	public interface IDetailedAppointment
	{
		string FirstName { get; set; }
		DateTime Date { get; set; }
		int Id { get; set; }
		public bool Completed { get; set; }
		string LastName { get; set; }
		string Make { get; set; }
		string Model { get; set; }
		string NumberPlate { get; set; }
		int MechanicId { get; set; }
		int VehicleId { get; set; }
		int CustomerId { get; set; }
		string UserName { get; set; }
	}
}