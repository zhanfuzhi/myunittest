using myproject.Customers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject.EntityFramework.Repositories.Customers
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["TaskPay"].ToString();

        public void First()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select taskid from sys_task";
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
