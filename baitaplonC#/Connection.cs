using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;

namespace baitaplonC_
{
    internal class Connection
    {
        private static string stringConnection = "Data Source=.\\sqlexpress;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
