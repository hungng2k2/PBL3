using System.Data;
using System.Data.SqlClient;

namespace PBL3
{
    public class QLCH
    {
        public static DataTable GetAllNhanvien()
        {
            DataTable data = new DataTable();
            string query = "select * from Nhanvien";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public static DataTable GetAllKhachhang()
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

        public static DataTable GetAllMonan()
        {
            DataTable data = new DataTable();
            string query = "select * from Monan";
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
