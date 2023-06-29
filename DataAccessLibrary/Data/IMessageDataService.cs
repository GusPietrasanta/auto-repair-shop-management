using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IMessageDataService
	{
		Task CreateMessage(IMessageModel newMessage);
	}
}