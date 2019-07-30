using myproject.Users;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.EntityFramework.Repositories.Users
{
    public class UserRepository:IUserRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

        public void First()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select code from [@product]";
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    using (var read = cmd.ExecuteReader())
                    {
             
                    }
                }
                conn.Close();
            }

        }

    }
}
