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
    public class DTO_Inspection : DTO_Base
    {
        [DataMember]
        public int InspectionID { get; set; }
        [DataMember]
        public int? ClaimID { get; set; }
        [DataMember]
        public int CustomerID { get; set; }

        public DateTime InspectionDate { get; set; }
        [DataMember(Name = "InspectionDate")]
        private string InspectionDateForSerialization { get; set; }
        [OnSerializing]
        void onSerializing(StreamingContext context)
        {
            if (InspectionDate != null)
                this.InspectionDateForSerialization = JsonConvert.SerializeObject(this.InspectionDate).Replace('"', ' ').Trim();
        }
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
        {
            if (InspectionDateForSerialization != null)
                this.InspectionDate = DateTime.Parse(this.InspectionDateForSerialization);
        }

        [DataMember]
        public int RoofAge { get; set; }
        [DataMember]
        public bool SkyLights { get; set; }
        [DataMember]
        public bool Leaks { get; set; }
        [DataMember]
        public bool GutterDamage { get; set; }
        [DataMember]
        public bool DrivewayDamage { get; set; }
        [DataMember]
        public bool MagneticRollers { get; set; }
        [DataMember]
        public bool IceWaterShield { get; set; }
        [DataMember]
        public bool EmergencyRepair { get; set; }
        [DataMember]
        public double? EmergencyRepairAmount { get; set; }
        [DataMember]
        public bool QualityControl { get; set; }
        [DataMember]
        public bool ProtectLandscaping { get; set; }
        [DataMember]
        public bool RemoveTrash { get; set; }
        [DataMember]
        public bool FurnishPermit { get; set; }
        [DataMember]
        public bool CoverPool { get; set; }
        [DataMember]
        public bool InteriorDamage { get; set; }
        [DataMember]
        public bool ExteriorDamage { get; set; }
        [DataMember]
        public bool Valley { get; set; }
        [DataMember]
        public int RidgeMaterialTypeID { get; set; }
        [DataMember]
        public int ShingleTypeID { get; set; }
        [DataMember]
        public bool TearOff { get; set; }
        [DataMember]
        public bool Satellite { get; set; }
        [DataMember]
        public bool SolarPanels { get; set; }
        [DataMember]
        public string Comments { get; set; }
        [DataMember]
        public bool LightningProtection { get; set; }

        //Added

        [DataMember]
        public string Ventilation { get; set; }
        [DataMember]
        public string Underlayment { get; set; }
        [DataMember]
        public string MetalEdgeColor { get; set; }
        [DataMember]
        public double SQFToff { get; set; }

        //Exterior
        [DataMember]
        public List<DTO_InspectionMeasurement> SidingMeasurements { get; set; }
        [DataMember]
        public string SidingType { get; set; }
        [DataMember]
        public double SidingSize { get; set; }
        [DataMember]
        public string SidingProfile { get; set; }
        [DataMember]
        public string SidingColor { get; set; }
        [DataMember]
        public string TrimColor { get; set; }


        //Gutters
        [DataMember]
        public List<DTO_InspectionMeasurement> GutterMeasurements { get; set; }
        [DataMember]
        public string GutterSize { get; set; }
        [DataMember]
        public string GutterColor { get; set; }
        [DataMember]
        public List<DTO_InspectionMeasurement> DownspoutMeasurements { get; set; }
        [DataMember]
        public string DownspoutSize { get; set; }
        [DataMember]
        public string DownspoutColor { get; set; }
        [DataMember]
        public string ExteriorComments { get; set; }


        //Interior

        [DataMember]
        public string InteriorComments { get; set; }

    }
}
