using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AutoKennis
{
    [DataContract]
    public class FormDTO
    {

        //GARANTIE KEURING, REPARATIE KEURING, AUTO ADVIES ADATOK

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Naam*:")]
		[SummaryTable]
        public string Fullname { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Adres*:")]
        public string Address { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Postcode*:")]
        public string Postcode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Woonplaats*:")]
        public string City { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Email-adres*:")]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Telefoonnummer*:")]
        public string PhoneNumberPrimary { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Alternatief telefoonnummer*:")]
        public string PhoneNumberAlternate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Gewenste datum ")]
        public string PreferredDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Gewenste tijdstip*:")]
        public string PreferredTime { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Merk*:")]
		[SummaryTable]
		public string CarBrand { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Type*:")]
		[SummaryTable]
		public string CarModel { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Kenteken*:")]
		[SummaryTable]
		public string CarLicencePlate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Bouwjaar*:")]
		[SummaryTable]
		public string CarYear { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Adres Auto*:")]
		[SummaryTable]
		public string CarAddress { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Woonplaats*:")]
		[SummaryTable]
		public string CarCity { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Postcode*:")]
		[SummaryTable]
		public string CarPostcode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Eventuele aanvullende gegevens kunt u hier invullen:")]
        public string Comments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Gevenste wijze van betalen:")]
        public string PaymentMethod { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("IP Address:")]
        public string IpAddress { get; set; }

        [IgnoreDataMember]
        public long id { get; set; }

        //Klik hier om u akkoord te verklaren met de algemene voorwaarden van Auto-Kennis*:
        //Submitted On:    datum
        //IP Address:





    }
}