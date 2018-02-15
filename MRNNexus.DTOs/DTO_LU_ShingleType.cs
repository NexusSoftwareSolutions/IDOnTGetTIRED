﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MRNNexusDTOs
{
    [KnownType(typeof(DTO_Base))]
    [DataContract]
    public class DTO_LU_ShingleType : DTO_Base
    {
        [DataMember]
        public int ShingleTypeID { get; set; }
        [DataMember]
        public string ShingleType { get; set; }
    }
}
