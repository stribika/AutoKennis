using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoKennisWeb
{
    public abstract class KeuringFormBaseClass : System.Web.UI.Page
    {
        static string server = "snowden.lan"; //"mail.auto-kennis.nl";

        private IFormDAO FormDAO
        {
            get
            {
                return AppConfig.Instance.FormDAO;
            }
        }

        private EmailSender EmailSender
        {
            get
            {
                return AppConfig.Instance.EmailSender;
            }
        }


        public static FormDTO FormDTOSend(HttpRequest Request)
        {
            var form = new FormDTO();

            form.Fullname = Request.Form.Get("fullname");
            form.Address = Request.Form.Get("address");
            form.Postcode = Request.Form.Get("postcode");
            form.City = Request.Form.Get("city");
            form.Email = Request.Form.Get("email");
            form.PhoneNumberPrimary = Request.Form.Get("phoneNumberPrimary");
            form.PhoneNumberAlternate = Request.Form.Get("phoneNumberAlternate");
            form.PreferredDate = Request.Form.Get("preferredDate");
            form.PreferredTime = Request.Form.Get("preferredTime");

            form.CarBrand = Request.Form.Get("carBrand");
            form.CarModel = Request.Form.Get("carModel");
            form.CarLicencePlate = Request.Form.Get("carLicencePlate");
            form.CarYear = Request.Form.Get("carYear");
            form.CarAddress = Request.Form.Get("carAddress");
            form.CarCity = Request.Form.Get("carCity");
            form.CarPostcode = Request.Form.Get("carPostcode");
            form.Comments = Request.Form.Get("comments");
            form.PaymentMethod = Request.Form.Get("paymentMethod");
            form.IpAddress = Request.UserHostAddress;

            return form;
        }

        public void SendOutMail(string selectedTable, string formtype)
        {
            List<FormDTO> formDTOList = FormDAO.LoadFormDTO(selectedTable);

            foreach (FormDTO currentForm in formDTOList)
            {
                FormDAO.EmailStateSetter(EmailSender.MailSend(server, FormDAO.SetEmailAddresses(), EmailSender.BodyBuilderFormDTO(formtype, currentForm), formtype), selectedTable, currentForm.id); // EMAIL SERVERT TESZTELESHEZ BEALLITANI
            }
        }
    }
}