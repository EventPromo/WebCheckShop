using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository
    {
        protected T GetConnection<T>(Func<IDbConnection, T> getData,  [CallerMemberName]string methodName = "")
        {
            var connectionString = ConnectionString;
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return ExecuteWithHandleDeadlock(() => getData(connection));
            }
        }
        
        private T ExecuteWithHandleDeadlock<T>(Func<T> func)
        {
            int tryCount = 5;
            do
            {
                try
                {
                    return func();
                }
                catch (SqlException sqlException)
                {
                    if (sqlException.Number != 1205 || --tryCount < 0)
                        throw;
                    System.Threading.Thread.Sleep(10);
                }
            } while (true);
        }
        
        public string ConnectionString { get; private set; }
    }
}
