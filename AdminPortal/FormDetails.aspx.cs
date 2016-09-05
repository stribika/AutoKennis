using System;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoKennis;

namespace AdminPortal
{
	public partial class FormDetails : System.Web.UI.Page
	{
		private IFormDAO FormDAO {
			get { return AppConfig.Instance.FormDAO; }
		}

		private FormType RequestFormType {
			get {
				foreach (var val in typeof(FormType).GetEnumValues()) {
					if (typeof(FormType).GetEnumName(val) == Request.QueryString["type"]) {
						return (FormType)val;
					}
				}

				throw new ArgumentException($"Invalid form type '{Request.QueryString["type"]}'");
			}
		}

		private long RequestId {
			get { return long.Parse(Request.QueryString["id"]); }
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			var formDTO = FormDAO.LoadForm(RequestFormType, RequestId);

			foreach (var field in formDTO.GetType().GetProperties()) {
				var label = field.GetCustomAttribute<NLNameAttribute>();
				if (label != null) {
					var formField = LoadControl("FormField.ascx") as FormField;
					formField.Label = label.NLName + (label.Mandatory ? "*" : "");
					formField.TextMode = TextBoxMode.SingleLine;
					formField.Text = field.GetValue(formDTO)?.ToString();
					form.Controls.Add(formField);
				}
			}
		}
	}
}

