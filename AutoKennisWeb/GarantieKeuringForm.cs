using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace AutoKennisWeb {
	
	public partial class GarantieKeuringForm : System.Web.UI.Page {
		public void submitButtonClicked(object sender, EventArgs args) {
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



            AppConfig.Instance.FormDAO.saveGarantieKeuringForm(form);

            //És kuldjon emailt is
            string selectedTable = "GarantieKeuringForm";
            string formtype = "Garantie-Keuring";
            string server = "mail.auto-kennis.nl";

            EmailSender emailSender = new EmailSender();
            List<FormDTO> formDTOList = AppConfig.Instance.FormDAO.LoadFormDTO(selectedTable);
            
            foreach (FormDTO currentForm in formDTOList)
            {
                emailSender.EmailStateSetter(emailSender.MailSend(server, emailSender.SetEmailAddresses(), emailSender.BodyBuilderFormDTO(formtype, currentForm), formtype), selectedTable, currentForm.id); // EMAIL SERVERT TESZTELESHEZ BEALLITANI
            }

            // Meg visszaigazoljon
        }
	}
}

