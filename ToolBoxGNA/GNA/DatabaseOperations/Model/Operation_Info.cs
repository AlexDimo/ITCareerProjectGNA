//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseOperations.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operation_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operation_Info()
        {
            this.Users = new HashSet<Users>();
        }
    
        public int id { get; set; }
        public int operation_id { get; set; }
        public string file_path { get; set; }
        public string file_type { get; set; }
        public int operation_type_id { get; set; }
        public Nullable<bool> isSuccessfull { get; set; }
        public string additional_info { get; set; }
    
        public virtual Operation_Ids Operation_Ids { get; set; }
        public virtual Operation_Types Operation_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users> Users { get; set; }
    }
}
