using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UIAppointmentModel : IAppointmentModel
	{
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
		[Required]
		public DateTime Date { get; set; }
		public int MechanicId { get; set; }
		public bool Completed { get; set; } = false;
    }
}
