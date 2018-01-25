namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int MaNV { get; set; }

        [StringLength(20)]
        public string TenNV { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(300)]
        public string HinhAnh { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        public int MaNhom { get; set; }

        public virtual NhomNhanVien NhomNhanVien { get; set; }
    }
}
