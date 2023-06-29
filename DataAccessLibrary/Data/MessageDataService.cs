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
	}
}
