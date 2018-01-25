namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoSanPham")]
    public partial class BaoCaoSanPham
    {
        [Key]
        public int MaBCSP { get; set; }

        public DateTime? NgayBC { get; set; }

        public int? SoLuongSP { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
