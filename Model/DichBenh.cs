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
    
    public partial class DichBenh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichBenh()
        {
            this.CoSoChanNuois = new HashSet<CoSoChanNuoi>();
            this.QuanLyTamGiuTieuHuys = new HashSet<QuanLyTamGiuTieuHuy>();
        }
    
        public string MaDichBenh { get; set; }
        public string TenDichBenh { get; set; }
        public Nullable<int> MucDoNguyHiem { get; set; }
        public string CachXuLy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoSoChanNuoi> CoSoChanNuois { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanLyTamGiuTieuHuy> QuanLyTamGiuTieuHuys { get; set; }
    }
}
