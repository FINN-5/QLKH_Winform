﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace baitaplonC_
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable Table(string query)//tra ve bang
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();

            }
            return dataTable;
        }
        public void Command(string query)// dung de them sua xoa
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
        }
    }
}
