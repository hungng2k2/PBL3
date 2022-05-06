﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class qlchtan1 : DbContext
    {
        public qlchtan1()
            : base("name=qlchtan1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Monan> Monan { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Order> Order { get; set; }
    
        public virtual int InsertNhanVien(string tenNV, Nullable<System.DateTime> ngaySinh, Nullable<bool> gioiTinh, string sDT, string diaChi)
        {
            var tenNVParameter = tenNV != null ?
                new ObjectParameter("TenNV", tenNV) :
                new ObjectParameter("TenNV", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var gioiTinhParameter = gioiTinh.HasValue ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(bool));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNhanVien", tenNVParameter, ngaySinhParameter, gioiTinhParameter, sDTParameter, diaChiParameter);
        }
    
        public virtual int InsertKhachHang(string tenKH, Nullable<System.DateTime> ngaySinh, Nullable<bool> gioiTinh, string sDT, string diaChi)
        {
            var tenKHParameter = tenKH != null ?
                new ObjectParameter("TenKH", tenKH) :
                new ObjectParameter("TenKH", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var gioiTinhParameter = gioiTinh.HasValue ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(bool));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertKhachHang", tenKHParameter, ngaySinhParameter, gioiTinhParameter, sDTParameter, diaChiParameter);
        }
    }
}
