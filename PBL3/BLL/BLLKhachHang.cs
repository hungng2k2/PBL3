using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{    class BLLKhachHang
    {
        qlchtan1 db = new qlchtan1();
        private static BLLKhachHang _Instance;

        public static BLLKhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLKhachHang();
                }
                return _Instance;
            }
            private set { }
        }

        private BLLKhachHang()
        {

        }

        public bool checkAddUpdate(string id)
        {
            bool Add = true;
            foreach (Khachhang i in db.Khachhang)
            {
                if (i.MAKH == id)
                    Add = false;
            }
            return Add;
        }

        public void Delete(string id)
        {
            db.Khachhang.Remove(db.Khachhang.Find(id));
            db.SaveChanges();
        }

        public void ExecuteAddUpdate(Khachhang t)
        {
            if (checkAddUpdate(t.MAKH))
            {
                db.InsertKhachHang(t.TENKH,t.NGAYSINH,t.GIOITINH,t.SDT,t.DIACHI);
                db.SaveChanges();
            }
            else
            {
                db.Khachhang.Find(t.MAKH).TENKH = t.TENKH;
                db.Khachhang.Find(t.MAKH).DIACHI = t.DIACHI;
                db.Khachhang.Find(t.MAKH).GIOITINH = t.GIOITINH;
                db.Khachhang.Find(t.MAKH).SDT = t.SDT;
                db.Khachhang.Find(t.MAKH).NGAYSINH = t.NGAYSINH;
                db.SaveChanges();
            }
        }

        public dynamic GetAll()
        {
            return db.Khachhang.ToList();
        }

        public dynamic GetById(string id)
        {
            return db.Khachhang.Find(id);
        }
    }
}
