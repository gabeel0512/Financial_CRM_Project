//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinancialCRM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBank()
        {
            this.TblProcess = new HashSet<TblProcess>();
        }
    
        public int BankId { get; set; }
        public string BankAccountNo { get; set; }
        public string BankTitle { get; set; }
        public Nullable<decimal> BankBalance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblProcess> TblProcess { get; set; }
    }
}
