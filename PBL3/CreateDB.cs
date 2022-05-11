using PBL3.DTO;
using System;
using System.Data.Entity;

namespace PBL3
{
    internal class CreateDB : DropCreateDatabaseAlways<QLCHTAN>
    {
        protected override void Seed(QLCHTAN context)
        {
            context.NhanVien.AddRange(new NhanVien[]
            {
                new NhanVien
                {
                    id_NhanVien = "NV000",
                    TenNhanVien = "Admin",
                    NgaySinh = new DateTime(2002,2,2),
                    GioiTinh = true,
                    SoDienThoai = "0123456789",
                    DiaChi = "Hội An",
                    Username = "Admin",
                    Password = "123456",
                    ChucVu = "QuanLy"
                },
                new NhanVien
                {
                    id_NhanVien = "NV001",
                    TenNhanVien = "Nguyễn Văn A",
                    NgaySinh = new DateTime(2002,2,2),
                    GioiTinh = true,
                    SoDienThoai = "0123456789",
                    DiaChi = "Hội An",
                    Username = "Admin",
                    Password = "123456",
                    ChucVu = "NhanVien"
                }
            });
        }
    }
}
