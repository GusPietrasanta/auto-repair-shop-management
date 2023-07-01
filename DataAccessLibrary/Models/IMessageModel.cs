namespace DataAccessLibrary.Models
{
	public interface IMessageModel
	{
		int ID { get; set; }
		string Content { get; set; }
		DateTime PostedOn { get; set; }
		string Tag { get; set; }
		string UserName { get; set; }
	}
}