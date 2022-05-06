using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class BllKhachhang
    {
        qlchtanEntities db = new qlchtanEntities();
        private static BllKhachhang _Instance;

        public static BllKhachhang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BllKhachhang();
                }
                return _Instance;
            }
            private set { }
        }

        private BllKhachhang()
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
            if (checkAddUpdate(t.MAKH) == true)
            {
                db.Khachhang.Add(t);
                db.SaveChanges();
            }
            else
            {
                db.Khachhang.Find(t.MAKH).TENKH = t.TENKH;
                db.Khachhang.Find(t.MAKH).NGAYSINH = t.NGAYSINH;
                db.Khachhang.Find(t.MAKH).GIOITINH = t.GIOITINH;
                db.Khachhang.Find(t.MAKH).DIACHI = t.DIACHI;
                db.Khachhang.Find(t.MAKH).SDT = t.SDT;
                db.SaveChanges();
            }
        }

        public dynamic GetById(string id)
        {
            return db.Khachhang.Find(id);
        }
        public dynamic GetAll()
        {
            return db.Khachhang.ToList();
        }
    }
}
