using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLibrary.DataAccess
{
	public class SqlDataAccess : ISqlDataAccess
	{
		private readonly IConfiguration _config;

		public SqlDataAccess(IConfiguration config)
		{
			_config = config;
		}

		public async Task<List<T>> LoadData<T, TU>(string storedProcedure, TU parameters, string connectionStringName)
		{
			string connectionString = _config.GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				var rows = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

				return rows.ToList();
			}
		}

		public async Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
		{
			string connectionString = _config.GetConnectionString(connectionStringName);

			using (IDbConnection connection = new SqlConnection(connectionString))
			{
				await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
