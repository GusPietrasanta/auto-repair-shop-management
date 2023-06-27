namespace DataAccessLibrary.Models
{
	public interface IAppointmentModel
	{
		bool Completed { get; set; }
		int CustomerID { get; set; }
		DateTime Date { get; set; }
		int ID { get; set; }
		int MechanicID { get; set; }
		int VehicleID { get; set; }
	}
}