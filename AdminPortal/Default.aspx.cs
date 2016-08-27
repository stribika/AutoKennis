using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoKennis;

namespace AdminPortal {
	public partial class Default : System.Web.UI.Page {
		private IList<PropertyInfo> Columns = new List<PropertyInfo>();

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			GarantieKeuringTable.Rows.Add(CreateHeader());
			foreach (var form : )
		}

		private TableRow CreateHeader()
		{
			var header = new TableRow();
			var properties = typeof(FormDTO).GetProperties();
			foreach (var prop in properties) {
				var attr = prop.GetCustomAttribute<NLNameAttribute>();
				if (attr != null && attr.SummaryTable) {
					var cell = new TableCell();
					cell.Text = attr.NLName;
					header.Cells.Add(cell);
					Columns.Add(prop);
				}
			}

			return header;
		}

		public void button1Clicked(object sender, EventArgs args) {
			button1.Text = "You clicked me";
		}
	}
}

