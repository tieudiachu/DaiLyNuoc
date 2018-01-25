namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThamSo")]
    public partial class ThamSo
    {
        [Key]
        public int MaTS { get; set; }

        [StringLength(50)]
        public string TenTS { get; set; }

        public int? GiaTri { get; set; }

        public DateTime? ThoiGianHieuLuc { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }
    }
}
