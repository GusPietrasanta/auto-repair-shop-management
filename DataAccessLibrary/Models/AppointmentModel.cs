namespace DataAccessLibrary.Models
{
	public class AppointmentModel : IAppointmentModel
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int VehicleId { get; set; }
		public DateTime Date { get; set; }
		public int MechanicId { get; set; }
		public bool Completed { get; set; } = false;
	}
}
