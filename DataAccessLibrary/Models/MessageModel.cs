namespace DataAccessLibrary.Models
{
	public class MessageModel : IMessageModel
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Content { get; set; }
		public DateTime PostedOn { get; set; }
		public string Tag { get; set; }
	}
}
