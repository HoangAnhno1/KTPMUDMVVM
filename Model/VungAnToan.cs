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
    
    public partial class VungAnToan
    {
        public string MaVAT { get; set; }
        public string TenVAT { get; set; }
        public string MaDB { get; set; }
    
        public virtual Dichbenh Dichbenh { get; set; }
    }
}