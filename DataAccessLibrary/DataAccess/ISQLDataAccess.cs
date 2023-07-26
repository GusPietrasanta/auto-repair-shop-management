namespace DataAccessLibrary.DataAccess
{
	public interface ISqlDataAccess
	{
		Task<List<T>> LoadData<T, TU>(string storedProcedure, TU parameters, string connectionStringName);
		Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
	}
}