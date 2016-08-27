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
		[NLNameAttribute("Uw Naam", mandatory: true, summaryTable: true)]
        public string Fullname { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Adres", mandatory: true)]
        public string Address { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Postcode", mandatory: true)]
        public string Postcode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Woonplaats", mandatory: true)]
        public string City { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Email-adres", mandatory: true)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Uw Telefoonnummer", mandatory: true)]
        public string PhoneNumberPrimary { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Alternatief telefoonnummer", mandatory: true)]
        public string PhoneNumberAlternate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Gewenste datum ")]
        public string PreferredDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Gewenste tijdstip", mandatory: true)]
        public string PreferredTime { get; set; }

        [DataMember(EmitDefaultValue = false)]
		[NLNameAttribute("Merk", mandatory: true, summaryTable: true)]
		public string CarBrand { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Type", mandatory: true, summaryTable: true)]
		public string CarModel { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Kenteken", mandatory: true, summaryTable: true)]
		public string CarLicencePlate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Bouwjaar", mandatory: true, summaryTable: true)]
		public string CarYear { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Adres Auto", mandatory: true, summaryTable: true)]
		public string CarAddress { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Woonplaats", mandatory: true, summaryTable: true)]
		public string CarCity { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [NLNameAttribute("Postcode", mandatory: true, summaryTable: true)]
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

		[IgnoreDataMember]
		public FormType Type { get; set; }

        //Klik hier om u akkoord te verklaren met de algemene voorwaarden van Auto-Kennis*:
        //Submitted On:    datum
        //IP Address:





    }
}