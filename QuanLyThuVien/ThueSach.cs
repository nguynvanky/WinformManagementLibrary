//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThueSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThueSach()
        {
            this.ChiTietThueSaches = new HashSet<ChiTietThueSach>();
        }
    
        public int MaThueSach { get; set; }
        public int MaNguoiThue { get; set; }
        public Nullable<int> SoSachDaMuon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThueSach> ChiTietThueSaches { get; set; }
        public virtual NguoiThue NguoiThue { get; set; }
    }
}
