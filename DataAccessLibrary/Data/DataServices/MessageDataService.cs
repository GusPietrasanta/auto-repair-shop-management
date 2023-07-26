using DataAccessLibrary.Data.Interfaces;
using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data.DataServices
{
	public class MessageDataService : IMessageDataService
	{
		private readonly ISqlDataAccess _dataAccess;

		public MessageDataService(ISqlDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task CreateMessage(IMessageModel newMessage)
		{
			var m = new
			{
				newMessage.UserName,
				newMessage.Content,
				newMessage.PostedOn,
				newMessage.Tag
			};
			
			await _dataAccess.SaveData("spMessage_Create", m, "SQLDB");
		}

		public async Task<List<IMessageModel>> ReadAllUnreadMessages()
		{
			var messages = await _dataAccess.LoadData<MessageModel, dynamic>("dbo.spMessage_ReadAll", new { }, "SQLDB");

			return messages.ToList<IMessageModel>();
		}

		public async Task MarkMessageAsRead(int id)
		{
			await _dataAccess.SaveData("spMessage_MarkAsRead", new { ID = id }, "SQLDB");
		}
	}
}
