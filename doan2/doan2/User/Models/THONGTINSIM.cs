//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace User.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THONGTINSIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THONGTINSIM()
        {
            this.CHITIETSDs = new HashSet<CHITIETSD>();
            this.HDCTs = new HashSet<HDCT>();
            this.HOADONDKs = new HashSet<HOADONDK>();
        }
    
        public string IDSIM { get; set; }
        public Nullable<int> MAKH { get; set; }
        public Nullable<bool> TRINHTRANG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETSD> CHITIETSDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDCT> HDCTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONDK> HOADONDKs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}