namespace DataAccessLibrary.Models
{
	public interface IDetailedAppointment
	{
		string FirstName { get; set; }
		DateTime Date { get; set; }
		int ID { get; set; }
		string LastName { get; set; }
		string Make { get; set; }
		string Model { get; set; }
		string NumberPlate { get; set; }
		int MechanicID { get; set; }
		int VehicleID { get; set; }
		string UserName { get; set; }
	}
}