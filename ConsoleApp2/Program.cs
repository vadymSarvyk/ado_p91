using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DBManager dBManager = new DBManager();
            dBManager.CreateConnection();
            dBManager.CechConnection();
        }
    }
}
