using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data
{
	public class MessageDataService : IMessageDataService
	{
		private readonly ISQLDataAccess _dataAccess;

		public MessageDataService(ISQLDataAccess dataAccess)
		{
			_dataAccess = dataAccess;
		}

		public async Task CreateMessage(IMessageModel newMessage)
		{
			await _dataAccess.SaveData("spMessage_Create", newMessage, "SQLDB");
		}

		public async Task<List<IMessageModel>> ReadAllUnreadMessages()
		{
			var messages = await _dataAccess.LoadData<MessageModel, dynamic>("dbo.spMessage_ReadAll", new { }, "SQLDB");

			return messages.ToList<IMessageModel>();
		}

		public async Task MarkMessageAsRead(int ID)
		{
			await _dataAccess.SaveData("spMessage_MarkAsRead", new { ID }, "SQLDB");
		}
	}
}
