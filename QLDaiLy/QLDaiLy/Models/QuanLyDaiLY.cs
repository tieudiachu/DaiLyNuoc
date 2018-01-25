namespace QLDaiLy.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyDaiLy : DbContext
    {
        public QuanLyDaiLy()
            : base("name=QuanLyDaiLy")
        {
        }

        public virtual DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }
        public virtual DbSet<BaoCaoSanPham> BaoCaoSanPhams { get; set; }
        public virtual DbSet<CTPhieuXuat> CTPhieuXuats { get; set; }
        public virtual DbSet<DaiLy> DaiLies { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomNhanVien> NhomNhanViens { get; set; }
        public virtual DbSet<PhieuThuTien> PhieuThuTiens { get; set; }
        public virtual DbSet<PhieuXuatHang> PhieuXuatHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThamSo> ThamSoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCaoDoanhThu>()
                .Property(e => e.TongNo)
                .HasPrecision(8, 0);

            modelBuilder.Entity<BaoCaoDoanhThu>()
                .Property(e => e.DaThanhToan)
                .HasPrecision(8, 0);

            modelBuilder.Entity<CTPhieuXuat>()
                .Property(e => e.DonGia)
                .HasPrecision(8, 0);

            modelBuilder.Entity<CTPhieuXuat>()
                .Property(e => e.TongTien)
                .HasPrecision(8, 0);

            modelBuilder.Entity<DaiLy>()
                .Property(e => e.CongNo)
                .HasPrecision(8, 0);

            modelBuilder.Entity<DaiLy>()
                .HasMany(e => e.PhieuThuTiens)
                .WithRequired(e => e.DaiLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DaiLy>()
                .HasMany(e => e.PhieuXuatHangs)
                .WithRequired(e => e.DaiLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhomNhanVien>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.NhomNhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThuTien>()
                .Property(e => e.SoTien)
                .HasPrecision(8, 0);

            modelBuilder.Entity<PhieuXuatHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(8, 0);

            modelBuilder.Entity<PhieuXuatHang>()
                .HasMany(e => e.CTPhieuXuats)
                .WithRequired(e => e.PhieuXuatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CTPhieuXuats)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
