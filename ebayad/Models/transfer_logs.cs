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
    
    public partial class transfer_logs
    {
        public int ID { get; set; }
        public Nullable<int> AUDITOR_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> ACCTING_RECEIVE_LOG_IG { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public Nullable<int> OVERRIDE_STATUS_ID { get; set; }
    }
}