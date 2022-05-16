using System;
using System.Data.Entity;
using System.Linq;
using PBL3.DTO;

namespace PBL3
{
    public class QLCHTAN : DbContext
    {
        // Your context has been configured to use a 'QLCHTAN' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3.QLCHTAN' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLCHTAN' 
        // connection string in the application configuration file.
        public QLCHTAN()
            : base("name=QLCHTAN")
        {
            Database.SetInitializer<QLCHTAN>(new CreateDB());
        }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<ChiTietOrder> ChiTietOrder { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}