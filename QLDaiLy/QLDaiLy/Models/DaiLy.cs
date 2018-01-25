namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaiLy")]
    public partial class DaiLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaiLy()
        {
            PhieuThuTiens = new HashSet<PhieuThuTien>();
            PhieuXuatHangs = new HashSet<PhieuXuatHang>();
        }

        [Key]
        public int MaDL { get; set; }

        [StringLength(50)]
        public string TenDL { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        public decimal? CongNo { get; set; }

        public DateTime? NgayDK { get; set; }

        public int? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuTien> PhieuThuTiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuXuatHang> PhieuXuatHangs { get; set; }
    }
}
