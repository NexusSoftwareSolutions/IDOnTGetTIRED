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
    
    public partial class LU_InspectionTypes
    {
        public System.Guid InspectionTypeID { get; set; }
        public string InspectionType { get; set; }
        public int InspectionID { get; set; }
    
        public virtual Inspection Inspection { get; set; }
    }
}