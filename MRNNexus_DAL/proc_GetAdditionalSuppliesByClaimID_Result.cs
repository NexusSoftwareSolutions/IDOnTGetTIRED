//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MRNNexus_DAL
{
    using System;
    
    public partial class proc_GetAdditionalSuppliesByClaimID_Result
    {
        public int AdditionalSuppliesID { get; set; }
        public int ClaimID { get; set; }
        public System.DateTime PickUpDate { get; set; }
        public System.DateTime DropOffDate { get; set; }
        public string Items { get; set; }
        public double Cost { get; set; }
        public string ReceiptImagePath { get; set; }
    }
}
