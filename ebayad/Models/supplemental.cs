//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ebayad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class supplemental
    {
        public int ID { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> SUPPLEMENTAL_TYPE_ID { get; set; }
        public Nullable<System.DateTime> APPROVE_DATE { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public string REASON_ONE { get; set; }
        public string REASON_TWO { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE { get; set; }
    }
}
