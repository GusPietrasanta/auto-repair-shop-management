namespace DataAccessLibrary.Models
{
	public interface IDashboardReportModel
	{
		string FirstName { get; set; }
		int Id { get; set; }
		string LastName { get; set; }
		string Make { get; set; }
		string Model { get; set; }
		string NumberPlate { get; set; }
		DateTime TimeFinished { get; set; }
		string UserName { get; set; }
		string Year { get; set; }
	}
}