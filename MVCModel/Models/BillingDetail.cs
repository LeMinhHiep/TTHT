//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCModel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillingDetail
    {
        public int BillingID { get; set; }
        public int SerialID { get; set; }
        public int ServiceID { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Amount { get; set; }
        public string Remarks { get; set; }
    
        public virtual BillingMaster BillingMaster { get; set; }
        public virtual ListService ListService { get; set; }
    }
}