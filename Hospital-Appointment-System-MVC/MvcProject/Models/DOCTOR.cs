//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DOCTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCTOR()
        {
            this.APPOINTMENTs = new HashSet<APPOINTMENT>();
            this.FEEDBACKs = new HashSet<FEEDBACK>();
        }
    
        public int doctorID { get; set; }
        public string doctorName { get; set; }
        public string doctorSurname { get; set; }
        public string phoneNumber { get; set; }
        public string e_mail { get; set; }
        public string doctorPassword { get; set; }
        public string department { get; set; }
        public string biography { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPOINTMENT> APPOINTMENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FEEDBACK> FEEDBACKs { get; set; }
    }
}
