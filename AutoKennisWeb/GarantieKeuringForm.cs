using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace AutoKennisWeb {
	
	public partial class GarantieKeuringForm : System.Web.UI.Page {
		public void submitButtonClicked(object sender, EventArgs args) {
            var form = new FormDTO();
            form.Fullname = Request.Form.Get("fullname");

            AppConfig.Instance.FormDAO.saveForm(form);
		}
	}
}

