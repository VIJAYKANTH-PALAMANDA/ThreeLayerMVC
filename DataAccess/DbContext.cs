using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbContext
    {
        private string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-ThreeLayer-20221029010426.mdf;Initial Catalog=aspnet-ThreeLayer-20221029010426;Integrated Security=True";
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
