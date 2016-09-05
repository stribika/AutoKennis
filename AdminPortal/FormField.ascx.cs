using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminPortal
{
	public partial class FormField : System.Web.UI.UserControl
	{
		public string Label { get; set; }

		private string glyphicon;
		public string Glyphicon {
			get { return glyphicon; }
			set {
				glyphicon = value;
				glyph.CssClass = $"glyphicon glyphicon-{value}";
			}
		}

		public string Prefix {
			get { return prefix.Text; }
			set { prefix.Text = value; }
		}

		public TextBoxMode TextMode {
			get { return textBox.TextMode; }
			set { textBox.TextMode = value; }
		}

		public string Placeholder {
			get { return textBox.Attributes["placeholder"]; }
			set { textBox.Attributes["placeholder"] = value; }
		}

		public string Text {
			get { return textBox.Text; }
			set { textBox.Text = value; }
		}
	}
}
