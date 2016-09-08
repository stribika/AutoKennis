using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Web;
using AutoKennis;

namespace AutoKennisWeb
{
    public abstract class KeuringFormBaseClass : System.Web.UI.Page
    {
        static string server = "localhost"; //"mail.auto-kennis.nl";

        protected IFormDAO FormDAO
        {
            get
            {
                return AppConfig.Instance.FormDAO;
            }
        }

        protected EmailSender EmailSender
        {
            get
            {
                return AppConfig.Instance.EmailSender;
            }
        }

		protected FormDTO CreateFormDTO(FormType type)
        {
            var form = new FormDTO();
			form.Type = type;

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

			ValidateFormDTO(form);

            return form;
        }

		protected void ValidateFormDTO(FormDTO form) {
			foreach (var prop in form.GetType().GetProperties()) {
				var mandatory = prop.GetCustomAttribute<NLNameAttribute>()?.Mandatory;
				if (mandatory.HasValue && mandatory.Value) {
					var val = prop.GetValue(form) as string;
					if (val == null || val.Length == 0) {
						throw new ArgumentNullException(prop.GetCustomAttribute<NLNameAttribute>().NLName);
					}
				}
			}
		}

		public void SendOutMail(FormType formType)
        {
			IList<FormDTO> formDTOList = FormDAO.LoadUnsentForms<FormDTO>(formType);

            foreach (FormDTO currentForm in formDTOList)
            {
				EmailSender.MailSend(server, FormDAO.GetEmailAddresses(), EmailSender.BodyBuilderFormDTO(currentForm), formType.GetDescription(), currentForm.Email.ToString());
				FormDAO.SetEmailSent(currentForm, true);
            }
        }
    }
}
