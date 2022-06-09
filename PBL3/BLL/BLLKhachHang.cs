﻿using PBL3.DTO;
using System;
using System.Linq;

namespace PBL3.BLL
{
    public class BLLKhachHang : BLLInterface<KhachHang>
    {
        QLCHTAN db = new QLCHTAN();
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
            if (db.KhachHang.Find(id) != null)
            {
                Add = false;
            }
            return Add;
        }

        public void Delete(string id)
        {
            db.KhachHang.Find(id).IsDeleted = true;
            db.SaveChanges();
        }
        public string AutoGeneratedId()
        {
            string id_next = "";
            string id_max = db.KhachHang.Select(p => p.id_KhachHang).ToList().Max();
            if (id_max == null)
            {
                id_next = "KH001";
            }
            else
            {
                int max = Convert.ToInt32(id_max.Substring(id_max.Length - 3));
                max++;
                id_next = "KH" + ("000" + max).Substring(("000" + max).Length - 3);
            }
            return id_next;
        }
        public void ExecuteAddUpdate(KhachHang t)
        {
            if (checkAddUpdate(t.id_KhachHang))
            {
                db.KhachHang.Add(new KhachHang
                {
                    id_KhachHang = t.id_KhachHang,
                    TenKhachHang = t.TenKhachHang,
                    NgaySinh = t.NgaySinh.Date,
                    GioiTinh = t.GioiTinh,
                    SoDienThoai = t.SoDienThoai,
                    DiaChi = t.DiaChi
                });
                db.SaveChanges();
            }
            else
            {
                KhachHang kh = db.KhachHang.Find(t.id_KhachHang);
                kh.TenKhachHang = t.TenKhachHang;
                kh.DiaChi = t.DiaChi;
                kh.GioiTinh = t.GioiTinh;
                kh.SoDienThoai = t.SoDienThoai;
                kh.NgaySinh = t.NgaySinh.Date;
                db.SaveChanges();
            }
        }

        public dynamic GetAll()
        {
            return db.KhachHang
                .Where(p => p.IsDeleted == false)
                .Select(p => new { p.id_KhachHang, p.TenKhachHang, p.NgaySinh, GioiTinh = p.GioiTinh ? "Nam" : "Nữ", p.SoDienThoai, p.DiaChi })
                .ToList();
        }

        public KhachHang GetById(string id)
        {
            return db.KhachHang.Find(id);
        }
        public dynamic Search(string name)
        {
            return db.KhachHang
                .Where(p => p.IsDeleted == false)
                .Where(p => p.TenKhachHang.Contains(name.ToLower()))
                .Select(p => new { p.id_KhachHang, p.TenKhachHang, p.NgaySinh, GioiTinh = p.GioiTinh ? "Nam" : "Nữ", p.SoDienThoai, p.DiaChi })
                .ToList();
        }
    }
}
