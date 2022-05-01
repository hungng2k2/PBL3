using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace PBL3.DAL
{
    class DALNhanVien : DALInterface<NhanVien>
    {
        private static DALNhanVien _Instance;

        public static DALNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALNhanVien();
                }
                return _Instance;
            }
            private set { }
        }

        private DALNhanVien()
        {

        }

        public void Add(NhanVien t)
        {
            string query = $"exec InsertNhanVien\n"+
                                $"@TenNV = '{t.Ten}',\n"+
		                        $"@NgaySinh = '{t.NgaySinh.ToString("yyyyMMdd")}',\n"+
		                        $"@GioiTinh = '{t.GioiTinh}',\n"+
		                        $"@SDT = '{t.SoDienThoai}',\n"+
		                        $"@DiaChi = '{t.DiaChi}'";
            DBHelper.Instance.ExcuteDB(query);
        }

        public void Delete(string id)
        {
            string query = $"delete from Nhanvien\n" +
                            $"where manv='{id}'";
            DBHelper.Instance.ExcuteDB(query);
        }

        public List<NhanVien> GetAll()
        {
            List<NhanVien> data = new List<NhanVien>();
            string query = "select * from Nhanvien";
            foreach (DataRow i in DBHelper.Instance.GetRecords(query).Rows)
            {
                data.Add(GetByDataRow(i));
            }
            return data;
        }

        public NhanVien GetByDataRow(DataRow i)
        {
            return new NhanVien
            {
                Id = i["MANV"].ToString(),
                Ten = i["TENNV"].ToString(),
                NgaySinh = Convert.ToDateTime(i["NGAYSINH"]),
                GioiTinh = i["GIOITINH"].ToString(),
                SoDienThoai = i["SDT"].ToString(),
                DiaChi = i["DIACHI"].ToString()
            };
        }

        public void Update(NhanVien t)
        {
            string query = $"update Nhanvien\n" +
                            $"set\n" +
                            $"tennv='{t.Ten}'\n" +
                            $",ngaysinh='{t.NgaySinh.ToString("yyyyMMdd")}'\n" +
                            $",gioitinh='{t.GioiTinh}'\n" +
                            $",sdt='{t.SoDienThoai}'\n" +
                            $"where manv='{t.Id}'";
            DBHelper.Instance.ExcuteDB(query);
        }

        
    }
}
