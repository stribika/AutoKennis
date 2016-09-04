using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using AutoKennis;

namespace AdminPortal {
	public partial class Login : System.Web.UI.Page {
		private IUserDAO UserDAO {
			get { return AppConfig.Instance.UserDAO; }
		}

		public void SubmitButtonClicked(object sender, EventArgs args) {
            if (ValidateUser(Username.Text, Password.Text)) {
            FormsAuthentication.RedirectFromLoginPage(Username.Text, createPersistentCookie: true);
			} else {
				ErrorMessage.Text = "Gebruikersnaam of wachtwoord incorrect.";
				ErrorMessage.Visible = true;
				Response.StatusCode = 403;
			}
		}

		private bool ValidateUser(string username, string password) {
			var user = UserDAO.GetUser(username);
			return user.Validate(password);
		}
	}
}

