namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoDoanhThu")]
    public partial class BaoCaoDoanhThu
    {
        [Key]
        public int MaBCDT { get; set; }

        public DateTime? NgayBC { get; set; }

        public decimal? TongNo { get; set; }

        public decimal? DaThanhToan { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
