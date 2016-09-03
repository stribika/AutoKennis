using System;
using System.Web;
using System.Web.UI;
using AutoKennis;
using System.Threading;

namespace AutoKennisWeb {
	public partial class AutoAdvies : KeuringFormBaseClass {
        public void submitButtonClicked(object sender, EventArgs args)
        {
            var form = CreateFormDTO(FormType.AutoAdvies);
            FormDAO.SaveForm(form);

            ThreadPool.SetMaxThreads(4, 16);
            ThreadPool.QueueUserWorkItem(new WaitCallback((x) => SendOutMail(FormType.AutoAdvies)));

            // Meg visszaigazoljon
            Response.Redirect("/confirmation.htm");
        }
	}
}

