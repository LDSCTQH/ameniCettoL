using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteCinema
{
    class SQLConnection
    {
        public static string connectionString()
        {
            string _connectionString = "Data Source=DESKTOP-TVEI7G0;Initial Catalog=cinema;Integrated Security=True";
            return _connectionString;
        }
    }

}
