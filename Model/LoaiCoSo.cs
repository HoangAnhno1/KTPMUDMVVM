//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KTPMUDMVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiCoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiCoSo()
        {
            this.CoQuanCapChungNhans = new HashSet<CoQuanCapChungNhan>();
            this.CoSoChanNuois = new HashSet<CoSoChanNuoi>();
            this.CoSoKhaoNghiemSPXLCTs = new HashSet<CoSoKhaoNghiemSPXLCT>();
            this.CoSoSanXuatSPXLCTs = new HashSet<CoSoSanXuatSPXLCT>();
            this.DaiLyThuocs = new HashSet<DaiLyThuoc>();
            this.QuanLyChiCucThuYs = new HashSet<QuanLyChiCucThuY>();
        }
    
        public string MaLCS { get; set; }
        public string TenLCS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoQuanCapChungNhan> CoQuanCapChungNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoSoChanNuoi> CoSoChanNuois { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoSoKhaoNghiemSPXLCT> CoSoKhaoNghiemSPXLCTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoSoSanXuatSPXLCT> CoSoSanXuatSPXLCTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DaiLyThuoc> DaiLyThuocs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanLyChiCucThuY> QuanLyChiCucThuYs { get; set; }
    }
}