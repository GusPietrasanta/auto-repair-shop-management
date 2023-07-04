namespace DataAccessLibrary.DataAccess
{
	public interface IManagerSessionData
	{
		string GetLastPage();
		void SetLastPage(string newLastPage);
	}
}