using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    class BLLNhanVien : BLLInterface<NhanVien>
    {
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
            return id == "";
        }

        public void Delete(string id)
        {
            DALNhanVien.Instance.Delete(id);
        }

        public void ExecuteAddUpdate(NhanVien t)
        {
            if (checkAddUpdate(t.Id))
            {
                DALNhanVien.Instance.Add(t);
            }
            else
            {
                DALNhanVien.Instance.Update(t);
            }
        }

        public List<NhanVien> GetAll()
        {
            return DALNhanVien.Instance.GetAll();
        }

        public NhanVien GetById(string id)
        {
            NhanVien nv = null;
            foreach(NhanVien i in DALNhanVien.Instance.GetAll())
            {
                if(i.Id == id)
                {
                    nv = i;
                }
            }
            return nv;
        }
    }
}
