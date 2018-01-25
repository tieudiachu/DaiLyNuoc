namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuXuat")]
    public partial class CTPhieuXuat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPX { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSP { get; set; }

        public int? SoLuong { get; set; }

        public decimal? DonGia { get; set; }

        public decimal? TongTien { get; set; }

        public virtual PhieuXuatHang PhieuXuatHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
