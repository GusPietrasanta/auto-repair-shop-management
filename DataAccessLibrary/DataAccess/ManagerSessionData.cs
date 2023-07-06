using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess
{
	public class ManagerSessionData : IManagerSessionData
	{
		public List<string> history = new List<string> { "/" };

		public void SetLastPage(string newLastPage)
		{
			history.Add(newLastPage);
		}

		public string GetLastPage()
		{
			if (history.Count > 0)
			{

                string output = history[history.Count - 1];
                history.RemoveAt(history.Count - 1);
                return output;
            }
			else
			{
				return "/";
			}
		}
	}
}
