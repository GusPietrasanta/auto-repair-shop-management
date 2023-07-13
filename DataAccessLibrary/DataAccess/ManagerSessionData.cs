namespace DataAccessLibrary.DataAccess
{
	public class ManagerSessionData : IManagerSessionData
	{
		public List<string> History = new List<string> { "/" };

		public void SetLastPage(string newLastPage)
		{
			History.Add(newLastPage);
		}

		public string GetLastPage()
		{
			if (History.Count > 0)
			{

                string output = History[History.Count - 1];
                History.RemoveAt(History.Count - 1);
                return output;
            }
			else
			{
				return "/";
			}
		}
	}
}
