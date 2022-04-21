using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PBL3
{
    public class QLCH
    {
       public DataTable GetAllNhanvien()
       {
            DataTable data = new DataTable();
            string query = "select * from Nhanvien";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {                 
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
       }
        public DataTable GetAllKhachhang()
        {
            DataTable data = new DataTable();
            string query = "select * from Khachhang";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }


    }
}
