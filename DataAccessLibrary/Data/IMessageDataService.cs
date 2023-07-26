﻿using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data
{
	public interface IMessageDataService
	{
		Task CreateMessage(IMessageModel newMessage);
		Task MarkMessageAsRead(int id);
		Task<List<IMessageModel>> ReadAllUnreadMessages();
	}
}