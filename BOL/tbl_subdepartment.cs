//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_subdepartment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_subdepartment()
        {
            this.tbl_employee = new HashSet<tbl_employee>();
        }
    
        public int sdept_id { get; set; }
        public string sdept_name { get; set; }
        public string sdept_strenght { get; set; }
        public Nullable<int> dept_id { get; set; }
    
        public virtual tbl_department tbl_department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_employee> tbl_employee { get; set; }
    }
}
