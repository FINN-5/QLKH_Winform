using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baitaplonC_
{
    public class DataProvider
    {
        private string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
