using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace AutoKennisWeb {
	
	public partial class GarantieKeuringForm : System.Web.UI.Page {
		public void submitButtonClicked(object sender, EventArgs args) {
			AppConfig.Instance.FormDAO.saveForm(4, new Dictionary<string, string>());
		}
	}
}

