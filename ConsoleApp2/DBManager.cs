using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DBManager
    {
        SqlConnection sql=null;
        public void CreateConnection() { sql= new SqlConnection();
            sql.ConnectionString = @"Data Source=WIN-57O3QHS7B6A\SQLEXPRESS; initial catalog=bookstore; integrated security=true;";
        }
        public void CechConnection()
        {
            SqlCommand comman = new SqlCommand();
            comman.Connection = sql;
            comman.CommandText = "insert into books values('vasya','vadym','1111')";
            try
            {
                sql.Open();
                comman.ExecuteNonQuery();
                Console.WriteLine("Connection successful");
            }
            finally
            {
                if(sql!=null)
                sql.Close();
            }
           
            
        }

    }
}
