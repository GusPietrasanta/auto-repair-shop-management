namespace DataAccessLibrary.Models
{
	public interface IAppointmentModel
	{
		bool Completed { get; set; }
		int CustomerId { get; set; }
		DateTime Date { get; set; }
		int Id { get; set; }
		int MechanicId { get; set; }
		int VehicleId { get; set; }
	}
}