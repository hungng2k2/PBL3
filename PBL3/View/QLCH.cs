using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.View
{
    public class QLCH
    {
        public static string checkLogin(string username, string password)
        {
            string quyen = "";
            QLCHTAN db = new QLCHTAN();
            var query = db.NhanVien.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if (query != null)
            {
                quyen = query.ChucVu;
            }
            return quyen.Trim();
        }
    }
}
