namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThuTien")]
    public partial class PhieuThuTien
    {
        [Key]
        public int MaPT { get; set; }

        public decimal? SoTien { get; set; }

        public DateTime? NgayThu { get; set; }

        public int MaNV { get; set; }

        public int MaDL { get; set; }

        public virtual DaiLy DaiLy { get; set; }
    }
}
