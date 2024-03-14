﻿using System;
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
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if(instance == null) 
                    instance = new DataProvider(); 
                return instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }


<<<<<<< HEAD
        private string connectionStr = "Data Source=23TH8\\MSSQLSERVER3;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";
            //"Data Source=.\\SQLEXPRESS;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";
=======
        private string connectionStr = "Data Source=.\\sqlexpress;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";
>>>>>>> 8ce98215e5edf7d6fa303eea8799a752ce8b96a3
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

        public int ExecuteNonQuery(string query)    // trả ra sl bản ghi bị ảnh hưởng bởi truy vấn
        {
            int data = 0;
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            data = command.ExecuteNonQuery();
            connection.Close();
            return data;
        }

        public object ExecuteScalar(string query)    // trả về cột đầu tiên của dòng đầu(ô đầu tiên) - count *
        {
            object data = 0;
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            data = command.ExecuteScalar();
            connection.Close();
            return data;
        }
    }

}
