using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataLibrary.DataAcess
{
    public static class SQLDataAcess
    {
        public static string GetConnectionString(string connectionName = "MVCDemoDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string SQL_Query)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(SQL_Query).ToList();
            } 
        }

        public static int SaveData<T>(string SQL_Query, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(SQL_Query, data);
            }
        }
    }
}
