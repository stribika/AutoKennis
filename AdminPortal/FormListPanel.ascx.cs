﻿using AutoKennis;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdminPortal
{

	public partial class FormListPanel : System.Web.UI.UserControl
	{
		public string Heading { get; set; }

		public IList<FormDTO> Data {
			set {
				foreach (var form in value) {
					var row = new TableRow();
					foreach (var col in CreateHeader()) {
						var cell = new TableCell();
						var link = new HyperLink();
						link.Text = col.GetValue(form)?.ToString();
						link.NavigateUrl = $"/FormDetails.aspx?type={form.Type}&id={form.id}";
						cell.Controls.Add(link);
						row.Cells.Add(cell);
					}
					table.Rows.Add(row);
				}
			}
		}

		private readonly object sync = new object();

		private volatile IList<PropertyInfo> Columns = null;

		private IList<PropertyInfo> CreateHeader()
		{
			if (Columns == null) {
				lock (sync) {
					if (Columns == null) {
						var cols = new List<PropertyInfo>();
						var properties = typeof(FormDTO).GetProperties();
						foreach (var prop in properties) {
							var columnName = prop.GetCustomAttribute<SummaryTableHeaderAttribute>()?.ColumnName;
							if (columnName != null) {
								var cell = new TableCell();
								cell.Text = columnName;
								tableHeader.Cells.Add(cell);
								cols.Add(prop);
							}
						}

						Columns = cols;
					}
				}
			}

			return Columns;
		}

		public bool ShowCompleted {
			get { return showCompleted.Checked; }
			set { showCompleted.Checked = value; }
		}

		public event EventHandler OnShowCompletedChanged;

		protected void SendShowCompletedChanged(object sender, EventArgs e)
		{
			var f = OnShowCompletedChanged;
			if (f != null) { f(this, e); }
		}

		public bool ShowDeleted {
			get { return showDeleted.Checked; }
			set { showDeleted.Checked = value; }
		}

		public event EventHandler OnShowDeletedChanged;

		protected void SendShowDeletedChanged(object sender, EventArgs e)
		{
			var f = OnShowDeletedChanged;
			if (f != null) { f(this, e); }
		}
	}

}

