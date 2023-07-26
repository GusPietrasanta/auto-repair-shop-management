namespace DataAccessLibrary.Models
{
	public class DashboardReportModel : IDashboardReportModel
	{
		public int Id { get; set; }
		public DateTime TimeFinished { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NumberPlate { get; set; }
		public string UserName { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Year { get; set; }
	}
}
