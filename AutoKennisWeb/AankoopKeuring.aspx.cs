using System;
using System.Web;
using System.Web.UI;
using AutoKennis;
using System.Threading;

namespace AutoKennisWeb {
	public partial class AankoopKeuring : KeuringFormBaseClass {
        public void submitButtonClicked(object sender, EventArgs args)
        {
            var form = CreateFormDTO(FormType.AankoopKeuring);
            FormDAO.SaveForm(form);

            ThreadPool.SetMaxThreads(4, 16);
            ThreadPool.QueueUserWorkItem(new WaitCallback((x) => SendOutMail(FormType.AankoopKeuring)));

            // Meg visszaigazoljon
            Response.Redirect("/confirmation.htm");
        }
	}
}

