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
    
    public partial class voucher_table
    {
        public int ID { get; set; }
        public string DOC_NUMBER { get; set; }
        public string PAYEE { get; set; }
        public string TIN { get; set; }
        public string RESPO { get; set; }
        public string ADDRESS { get; set; }
        public string OBR_NO { get; set; }
        public string OFFICE_UNIT { get; set; }
        public string ACCOUNT_CODES { get; set; }
        public string EXPLANATION { get; set; }
        public Nullable<double> GROSS_AMOUNT { get; set; }
        public Nullable<double> DEDUCTION_AMOUNT { get; set; }
        public Nullable<double> TOTAL_AMOUNT { get; set; }
        public string DV_NUMBER { get; set; }
        public Nullable<int> FUND_TYPE { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public string CHECK_NUMBER { get; set; }
    }
}