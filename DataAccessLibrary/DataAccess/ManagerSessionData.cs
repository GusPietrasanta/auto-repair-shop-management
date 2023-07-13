namespace DataAccessLibrary.DataAccess
{
	public class ManagerSessionData : IManagerSessionData
	{
		private List<string> _history = new() { "/" };

		public void SetLastPage(string newLastPage)
		{
			_history.Add(newLastPage);
		}

		public string GetLastPage()
		{
			if (_history.Count > 0)
			{

                string output = _history[^1];
                _history.RemoveAt(_history.Count - 1);
                return output;
            }
			else
			{
				return "/";
			}
		}
	}
}
