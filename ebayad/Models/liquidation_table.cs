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
    
    public partial class liquidation_table
    {
        public int ID { get; set; }
        public string DOCUMENT_NO { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public string CLAIMANT { get; set; }
        public string EXPLANATION { get; set; }
        public Nullable<System.DateTime> LR_DATE { get; set; }
        public Nullable<double> ORIGINAL_AMOUNT { get; set; }
        public Nullable<double> AUDITED_AMOUNT { get; set; }
        public string DV_NUMBER { get; set; }
        public Nullable<double> DV_AMOUNT { get; set; }
        public Nullable<System.DateTime> DV_DATE { get; set; }
        public Nullable<double> REFUND_AMOUNT { get; set; }
        public Nullable<double> FINAL_REFUND { get; set; }
        public Nullable<double> REIMBURSE_AMOUNT { get; set; }
        public Nullable<double> FINAL_REIMBURSE { get; set; }
        public string LR_NUMBER { get; set; }
        public string OR_NUMBER { get; set; }
        public Nullable<int> FUND_SOURCE_ID { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
    }
}