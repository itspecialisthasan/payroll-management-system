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
    
    public partial class tbl_department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_department()
        {
            this.tbl_employee = new HashSet<tbl_employee>();
            this.tbl_subdepartment = new HashSet<tbl_subdepartment>();
        }
    
        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public string dept_strenght { get; set; }
        public string dept_otrates { get; set; }
        public Nullable<int> unit_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_employee> tbl_employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subdepartment> tbl_subdepartment { get; set; }
        public virtual tbl_millUnit tbl_millUnit { get; set; }
    }
}
