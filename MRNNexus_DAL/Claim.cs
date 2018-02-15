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
    using System.Collections.Generic;
    
    public partial class Claim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Claim()
        {
            this.AdditionalSupplies = new HashSet<AdditionalSupply>();
            this.Adjustments = new HashSet<Adjustment>();
            this.CalendarDatas = new HashSet<CalendarData>();
            this.CallLogs = new HashSet<CallLog>();
            this.ClaimContacts = new HashSet<ClaimContact>();
            this.ClaimDocuments = new HashSet<ClaimDocument>();
            this.ClaimStatuses = new HashSet<ClaimStatus>();
            this.ClaimVendors = new HashSet<ClaimVendor>();
            this.Inspections = new HashSet<Inspection>();
            this.Invoices = new HashSet<Invoice>();
            this.NewRoofs = new HashSet<NewRoof>();
            this.Orders = new HashSet<Order>();
            this.Payments = new HashSet<Payment>();
            this.Scopes = new HashSet<Scope>();
            this.SurplusSupplies = new HashSet<SurplusSupply>();
        }
    
        public int ClaimID { get; set; }
        public int CustomerID { get; set; }
        public int LeadID { get; set; }
        public int BillingID { get; set; }
        public int PropertyID { get; set; }
        public int InsuranceCompanyID { get; set; }
        public string InsuranceClaimNumber { get; set; }
        public string MRNNumber { get; set; }
        public System.DateTime LossDate { get; set; }
        public string MortgageCompany { get; set; }
        public string MortgageAccount { get; set; }
        public bool IsOpen { get; set; }
        public bool ContractSigned { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdditionalSupply> AdditionalSupplies { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjustment> Adjustments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarData> CalendarDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallLog> CallLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimContact> ClaimContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimDocument> ClaimDocuments { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual InsuranceCompany InsuranceCompany { get; set; }
        public virtual Lead Lead { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimStatus> ClaimStatuses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimVendor> ClaimVendors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspection> Inspections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewRoof> NewRoofs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Scope> Scopes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurplusSupply> SurplusSupplies { get; set; }
    }
}