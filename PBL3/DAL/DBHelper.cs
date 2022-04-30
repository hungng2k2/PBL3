using System.Data;
using System.Data.SqlClient;

namespace PBL3.DAL
{
    class DBHelper
    {
        private static DBHelper _Instance;

        private static string s = @"Data Source=LAPTOP-BCBKO5G2\MSSQL181;Initial Catalog=qlchtan;Integrated Security=True";

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {   
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }

        private SqlConnection cnn;

        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }

        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            da.Fill(dt);
            return dt;
        }

    }
}
