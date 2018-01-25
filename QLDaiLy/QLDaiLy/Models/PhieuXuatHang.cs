namespace QLDaiLy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXuatHang")]
    public partial class PhieuXuatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXuatHang()
        {
            CTPhieuXuats = new HashSet<CTPhieuXuat>();
        }

        [Key]
        public int MaPX { get; set; }

        public DateTime? NgayXuat { get; set; }

        public decimal? ThanhTien { get; set; }

        public int MaNV { get; set; }

        public int MaDL { get; set; }

        public int? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> CTPhieuXuats { get; set; }

        public virtual DaiLy DaiLy { get; set; }
    }
}
