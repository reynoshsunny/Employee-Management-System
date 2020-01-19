using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    public class ConnectDb
    {
        public static SqlConnection Connect_Db() {

            string connStr = "Data Source=192.168.100.19,1433;Initial Catalog=EMS;User ID=sa;Password=parayilla";
            SqlConnection con = new SqlConnection(connStr);
            return con;
        }

    }
}
