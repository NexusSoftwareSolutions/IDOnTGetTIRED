using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MRNNexusDTOs
{
    [KnownType(typeof(DTO_Base))]

    [DataContract]
    public class DTO_InspectionMeasurement : DTO_Base
    {
        [DataMember]
        public int InspectionMeasurementID { get; set; } //UID
        [DataMember]
        public int InspectionID { get; set; } //FK
        [DataMember]
        public int InspectionMeasurementTypeID { get; set; } //Window-siding-shutter-drapes-etc
        [DataMember]
        public int InspectionTypeID { get; set; }   //Interior-Exterior-Gutters
        [DataMember]
        public double Width { get; set; }
        [DataMember]
        public double Height { get; set; }



    }
}