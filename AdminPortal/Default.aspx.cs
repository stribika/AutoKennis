using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoKennis;

namespace AdminPortal {
	public partial class Default : System.Web.UI.Page {
		private IFormDAO FormDAO { 
			get { return AppConfig.Instance.FormDAO; }
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			AutoAdvies.Data = FormDAO.LoadActiveForms<FormDTO>(FormType.AutoAdvies);
			AankoopBegeleiding.Data = FormDAO.LoadActiveForms<FormDTO>(FormType.AankoopBegeleiding);
			AankoopKeuring.Data = FormDAO.LoadActiveForms<FormDTO>(FormType.AankoopKeuring);
			GarantieKeuring.Data = FormDAO.LoadActiveForms<FormDTO>(FormType.GarantieKeuring);
			ReparatieKeuring.Data = FormDAO.LoadActiveForms<FormDTO>(FormType.ReparatieKeuring);
		}
	}
}

