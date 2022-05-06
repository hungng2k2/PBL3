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
            qlchtan1 db = new qlchtan1();
            var query = db.Nhanvien.Where(p => p.Username == username && p.Password == password).FirstOrDefault();
            if (query != null)
            {
                quyen = query.Chucvu;
            }
            return quyen.Trim();
        }
    }
}
