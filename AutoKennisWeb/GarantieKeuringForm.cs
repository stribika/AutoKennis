using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Threading;
using AutoKennis;

namespace AutoKennisWeb {
	public partial class GarantieKeuringForm : KeuringFormBaseClass {
		public void submitButtonClicked(object sender, EventArgs args) {
			var form = CreateFormDTO(FormType.GarantieKeuring);
			FormDAO.SaveForm(form);

            ThreadPool.SetMaxThreads(4,16);
            ThreadPool.QueueUserWorkItem(new WaitCallback((x) => SendOutMail(FormType.GarantieKeuring)));

            // Meg visszaigazoljon
            Response.Redirect("/confirmation.htm");
        }
	}
}
