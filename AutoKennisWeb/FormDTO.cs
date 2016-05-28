using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoKennisWeb
{
    public class FormDTO
    {
        //garantie keuring adatok
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumberPrimary { get; set; }
        public string PhoneNumberAlternate { get; set; }
        public string PreferredDate { get; set; }
        public string PreferredTime { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarLicencePlate { get; set; }
        public string CarYear { get; set; }
        public string CarAddress { get; set; }
        public string CarCity { get; set; }
        public string CarPostcode { get; set; }
        public string Comments { get; set; }
        public string PaymentMethod { get; set; }

        //aankoop begeleiding adatok

        public string SellerPhoneNumber { get; set; }
        public string SellerType { get; set; }
        public string CarPrice { get; set; }



    }
}