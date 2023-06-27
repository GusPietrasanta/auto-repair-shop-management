using DataAccessLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
	public class UIAppointmentModel : IAppointmentModel
	{
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
		[Required]
		public DateTime Date { get; set; }
		public int MechanicID { get; set; }
		public bool Completed { get; set; } = false;
    }
}
