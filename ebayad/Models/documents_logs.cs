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
    
    public partial class documents_logs
    {
        public int ID { get; set; }
        public string DOCUMENT_NUMBER { get; set; }
        public Nullable<int> RECEIVED_STATUS { get; set; }
        public Nullable<System.DateTime> RECEIVED_DATE { get; set; }
        public Nullable<int> APPROVED_STATUS { get; set; }
        public Nullable<int> RELEASE_STATUS { get; set; }
        public Nullable<System.DateTime> RELEASE_DATE { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public string REMARKS { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> FUNDCONTROLLER_ID { get; set; }
        public Nullable<System.DateTime> APPROVED_DATE { get; set; }
        public Nullable<int> BATCH_NO { get; set; }
    }
}
