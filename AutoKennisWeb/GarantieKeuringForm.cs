using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Threading;
using AutoKennis;

namespace AutoKennisWeb {
	
	public partial class GarantieKeuringForm : KeuringFormBaseClass {
        private string selectedTable = "GarantieKeuringForm";
        private string formtype = "Garantie-Keuring";

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

		public void submitButtonClicked(object sender, EventArgs args) {

            ThreadPool.SetMaxThreads(4,16);

            FormDAO.saveGarantieKeuringForm(KeuringFormBaseClass.FormDTOSend(Request));

            ThreadPool.QueueUserWorkItem(new WaitCallback((x) => SendOutMail(selectedTable, formtype)));


            // Meg visszaigazoljon
            Response.Redirect("/confirmation.htm");
        }
	}
}

