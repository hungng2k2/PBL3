using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLLNhanVien
    {
        qlchtan1 db = new qlchtan1();
        private static BLLNhanVien _Instance;

        public static BLLNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLNhanVien();
                }
                return _Instance;
            }
            private set { }
        }

        private BLLNhanVien()
        {

        }

        public bool checkAddUpdate(string id)
        {
            bool Add = true;
            foreach (Nhanvien i in db.Nhanvien)
            {
                if (i.MANV == id)
                    Add = false;
            }
            return Add;
        }

        public void Delete(string id)
        {
            db.Nhanvien.Remove(db.Nhanvien.Find(id));
            db.SaveChanges();
        }

        public void ExecuteAddUpdate(Nhanvien t)
        {
            if (checkAddUpdate(t.MANV))
            {
                db.InsertNhanVien(t.TENNV,t.NGAYSINH,t.GIOITINH,t.SDT,t.DIACHI);
                db.SaveChanges();
            }
            else
            {
                db.Nhanvien.Find(t.MANV).TENNV = t.TENNV;
                db.Nhanvien.Find(t.MANV).DIACHI = t.DIACHI;
                db.Nhanvien.Find(t.MANV).GIOITINH = t.GIOITINH;
                db.Nhanvien.Find(t.MANV).SDT = t.SDT;
                db.Nhanvien.Find(t.MANV).NGAYSINH = t.NGAYSINH;
                db.SaveChanges();
            }
        }

        public dynamic GetAll()
        {
            return db.Nhanvien.ToList();
        }

        public dynamic GetById(string id)
        {
            return db.Nhanvien.Find(id);
        }
    }
}
