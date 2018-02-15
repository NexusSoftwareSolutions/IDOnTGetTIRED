using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MRNNexusDTOs
{
    [DataContract]
    [KnownType(typeof(DTO_Base))]
    public class DTO_LU_InspectionMeasurementType : DTO_Base
    {
        [DataMember]
        public int InspectionMeasurementTypeID { get; set; }
        [DataMember]
        public string InspectionMeasurementType { get; set; }
    }
}
