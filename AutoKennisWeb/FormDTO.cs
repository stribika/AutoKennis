using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AutoKennisWeb
{
    [DataContract]
    public class FormDTO
    {
        
        //garantie keuring adatok
        [DataMember(EmitDefaultValue = false)]
        public string Fullname { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Address { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Postcode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string City { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PhoneNumberPrimary { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PhoneNumberAlternate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PreferredDate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PreferredTime { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarBrand { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarModel { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarLicencePlate { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarYear { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarAddress { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarCity { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarPostcode { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string Comments { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string PaymentMethod { get; set; }

        //aankoop begeleiding adatok

        [DataMember(EmitDefaultValue = false)]
        public string SellerPhoneNumber { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string SellerType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string CarPrice { get; set; }



    }
}