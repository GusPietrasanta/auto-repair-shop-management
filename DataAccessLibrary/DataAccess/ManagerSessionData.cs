using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
	public class ManagerSessionData : IManagerSessionData
	{
		public string LastPage = "/";

		public void SetLastPage(string newLastPage)
		{
			LastPage = newLastPage;
		}

		public string GetLastPage()
		{
			return LastPage;
		}
	}
}
