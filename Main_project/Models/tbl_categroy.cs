//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main_project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_categroy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_categroy()
        {
            this.TBL_QUESTIONS = new HashSet<TBL_QUESTIONS>();
        }
    
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public Nullable<int> cat_fk_adid { get; set; }
    
        public virtual TBL_ADMIN TBL_ADMIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_QUESTIONS> TBL_QUESTIONS { get; set; }
    }
}
