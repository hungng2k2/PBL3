using PBL3.DTO;
using System;
using System.Data.Entity;

namespace PBL3
{
    internal class CreateDB :
        //DropCreateDatabaseAlways<QLCHTAN>
        DropCreateDatabaseIfModelChanges<QLCHTAN>
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
                    Username = "NV001",
                    Password = "123456",
                    ChucVu = "NhanVien"
                },
                new NhanVien
                {
                    id_NhanVien = "NV002",
                    TenNhanVien = "Nguyễn Văn B",
                    NgaySinh = new DateTime(2002,2,9),
                    GioiTinh = true,
                    SoDienThoai = "0123456879",
                    DiaChi = "Đà Nẵng",
                    Username = "NV002",
                    Password = "123456",
                    ChucVu = "NhanVien"
                }
            });

            context.MonAn.AddRange(new MonAn[]
            {
                new MonAn { id_MonAn = "MA001", TenMonAn = "Gà chiên giòn",GiaNhap = 25000, GiaBan = 30000, SoLuong = 10, imagePath = @".\image\MA001.jpg" },
                new MonAn { id_MonAn = "MA002", TenMonAn = "Gà sốt cay", GiaNhap = 30000,GiaBan = 35000, SoLuong = 10, imagePath = @".\image\MA002.jpg" },
                new MonAn { id_MonAn = "MA003", TenMonAn = "Khoai tây chiên lớn",GiaNhap = 15000, GiaBan = 25000, SoLuong = 10, imagePath = @".\image\MA003.jpg" },
                new MonAn { id_MonAn = "MA004", TenMonAn = "Khoai tây lắc vị BBQ lớn",GiaNhap = 28000, GiaBan = 35000, SoLuong = 10, imagePath = @".\image\MA004.jpg" },
                new MonAn { id_MonAn = "MA005", TenMonAn = "Khoai viên rong biển",GiaNhap = 15000, GiaBan = 25000, SoLuong = 10, imagePath = @".\image\MA005.jpg" },
                new MonAn { id_MonAn = "MA006", TenMonAn = "Burger bò phô mai đặc biệt",GiaNhap = 44000, GiaBan = 52000, SoLuong = 10, imagePath = @".\image\MA006.jpg" },
                new MonAn { id_MonAn = "MA007", TenMonAn = "Burger bò phô mai 2 lớp",GiaNhap = 52000, GiaBan = 62000, SoLuong = 10, imagePath = @".\image\MA007.jpg" },
                new MonAn { id_MonAn = "MA008", TenMonAn = "Burger bò hoàng gia đặc biệt",GiaNhap = 60000, GiaBan = 82000, SoLuong = 10, imagePath = @".\image\MA008.jpg" },
                new MonAn { id_MonAn = "MA009", TenMonAn = "Burger gà cay",GiaNhap = 65000, GiaBan = 82000, SoLuong = 10, imagePath = @".\image\MA009.jpg" },
                new MonAn { id_MonAn = "MA010", TenMonAn = "Burger gà sốt mayo",GiaNhap = 55000, GiaBan = 62000, SoLuong = 10, imagePath = @".\image\MA010.jpg" },
                new MonAn { id_MonAn = "MA011", TenMonAn = "Burger cá",GiaNhap = 43000, GiaBan = 52000, SoLuong = 10, imagePath = @".\image\MA011.jpg" },
                new MonAn { id_MonAn = "MA012", TenMonAn = "Bánh táo hương quế",GiaNhap = 35000, GiaBan = 52000, SoLuong = 10, imagePath = @".\image\MA012.jpg" },
                new MonAn { id_MonAn = "MA013", TenMonAn = "Pizza gà BBQ nướng dứa",GiaNhap = 70000, GiaBan = 89000, SoLuong = 10, imagePath = @".\image\MA013.jpg" },
                new MonAn { id_MonAn = "MA014", TenMonAn = "Pizza giăm bông & thịt xông khói",GiaNhap = 68000, GiaBan = 89000, SoLuong = 10, imagePath = @".\image\MA014.jpg"},
                new MonAn { id_MonAn = "MA015", TenMonAn = "Pizza thanh cua & xúc xích",GiaNhap = 75000, GiaBan = 89000, SoLuong = 10, imagePath = @".\image\MA015.jpg" }
            });

            context.KhachHang.AddRange(new KhachHang[]
            {
                new KhachHang {id_KhachHang = "KH001", TenKhachHang = "Nguyễn Văn A", NgaySinh = new DateTime(2002,2,2), GioiTinh = true, SoDienThoai = "0123456789", DiaChi = "Huế"},
                new KhachHang {id_KhachHang = "KH002", TenKhachHang = "Bùi Thành Nhân", NgaySinh = new DateTime(2001,3,9), GioiTinh = true, SoDienThoai = "0123456792", DiaChi = "Đà Nẵng"},
                new KhachHang {id_KhachHang = "KH003", TenKhachHang = "Trần Thế Anh", NgaySinh = new DateTime(1992,5,23), GioiTinh = true, SoDienThoai = "0123454292", DiaChi = "Quảng Nam"},
            });
            
            //context.HoaDon.AddRange(new HoaDon[]
            //{
            //});
        }
    }
}
