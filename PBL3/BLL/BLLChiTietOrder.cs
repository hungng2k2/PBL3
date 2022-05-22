﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class BLLChiTietOrder : BLLInterface<ChiTietOrder>
    {
        QLCHTAN db;
        private static BLLChiTietOrder _Instance;

        public static BLLChiTietOrder Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLChiTietOrder();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLChiTietOrder()
        {
            db = new QLCHTAN();
        }
        public bool checkAddUpdate(string id)
        {
            bool Add = true;
            if (db.ChiTietOrder.Find(id) != null)
            {
                Add = false;
            }
            return Add;
        }

        public void Delete(string id)
        {
            db.ChiTietOrder.Remove(db.ChiTietOrder.Find(id));
            db.SaveChanges();
        }
        public string AutoGeneratedId()
        {
            string id_next = "";
            string id_max = db.ChiTietOrder.Select(p => p.id_ChiTietOrder).ToList().Max();
            if (id_max == null)
            {
                id_next = "CT000001";
            }
            else
            {
                int max = Convert.ToInt32(id_max.Substring(id_max.Length - 6));
                max++;
                id_next = "CT" + ("000000" + max).Substring(("000000" + max).Length - 6);
            }
            return id_next;
        }
        public void ExecuteAddUpdate(ChiTietOrder t)
        {
            if (checkAddUpdate(t.id_Order))
            {
                db.ChiTietOrder.Add(new ChiTietOrder
                {
                    id_ChiTietOrder = AutoGeneratedId(),
                    id_Order = t.id_Order,
                    id_MonAn = t.id_MonAn,
                    SoLuong = t.SoLuong,
                    DonGia = t.DonGia,
                });
                db.SaveChanges();
            }
            else
            {
                ChiTietOrder ct = db.ChiTietOrder.Find(t.id_ChiTietOrder);
                ct.id_Order = t.id_Order;
                ct.id_MonAn = t.id_MonAn;
                ct.SoLuong = t.SoLuong;
                ct.DonGia = t.DonGia;
                db.SaveChanges();
            }
        }

        public dynamic GetAll()
        {
            return db.ChiTietOrder.Select(p => p).ToList();
        }

        public ChiTietOrder GetById(string id)
        {
            return db.ChiTietOrder.Find(id);
        }
        public dynamic GetByIdOrder(string id_Order)
        {
            return db.ChiTietOrder.Where(p => p.id_Order == id_Order)
                .Select(p => new { p.MonAn.TenMonAn, p.SoLuong, p.DonGia, ThanhTien = p.DonGia * p.SoLuong })
                .ToList();
        }
        public void ExcuteListMonAn(string id_Order, List<MonAn> monAns)
        {
            foreach (MonAn monAn in monAns)
            {
                ExecuteAddUpdate(new ChiTietOrder
                {
                    id_Order = id_Order,
                    id_MonAn = monAn.id_MonAn,
                    SoLuong = monAn.SoLuong,
                    DonGia = monAn.GiaBan
                });
            }
        }
    }
}
