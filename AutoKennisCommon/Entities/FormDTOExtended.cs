using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AutoKennis
{
    [DataContract]
    public class FormDTOExtended : FormDTO
    {
        //AANKOOP KEURING, AANKOOP BEGELEIDING ADATOK

        [DataMember(EmitDefaultValue = false)]
        public string SellerPhoneNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SellerType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CarPrice { get; set; }

    }
}