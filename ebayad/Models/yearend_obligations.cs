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
    
    public partial class yearend_obligations
    {
        public int ID { get; set; }
        public Nullable<int> OBR_ID { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public string JEV_NO_ { get; set; }
        public Nullable<int> BUNDLE_NO { get; set; }
        public Nullable<System.DateTime> RELEASED_DATE { get; set; }
        public Nullable<int> RECEIVE_DEPT_ID { get; set; }
        public Nullable<int> RECEIVE_BY { get; set; }
        public Nullable<int> RELEASE_BY { get; set; }
        public Nullable<int> FORWARDED_TO { get; set; }
        public Nullable<int> STAMPED_BY_USER_ID { get; set; }
        public string REMARKS { get; set; }
        public Nullable<int> STATUS_ID { get; set; }
        public string RELEASED_TO { get; set; }
    }
}
