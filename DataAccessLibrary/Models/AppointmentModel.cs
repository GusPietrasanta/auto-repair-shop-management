namespace DataAccessLibrary.Models
{
	public class AppointmentModel : IAppointmentModel
	{
		public int ID { get; set; }
		public int CustomerID { get; set; }
		public int VehicleID { get; set; }
		public DateTime Date { get; set; }
		public int MechanicID { get; set; }
		public bool Completed { get; set; } = false;
	}
}
