using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DapperExample
{
    public abstract class SqlRepositoryBase
    {
        private const string ConnectionString = "Data Source=localhost;user id=sa;password=Admin#123";

        public IEnumerable<T> Query<T>(object param = null, int? commandTimeout = null, [CallerMemberName] string methodName = "")
        {
            var fileName = $"{GetType().Name}.{methodName}.sql";
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var sql = GetType().Assembly.GetResourceTextFileContent(fileName);
                return conn.Query<T>(sql, param, commandTimeout: commandTimeout);
            }
        }

    }
}
