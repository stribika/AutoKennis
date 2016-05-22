using System;
using System.Data.Common;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AutoKennisWeb {
	public sealed class FormDAO: IFormDAO {
		private DbProviderFactory Provider { get; set; }

		private string ConnectionString { get; set; }

		private DataContractJsonSerializer Json { get; set; }

		public FormDAO(string connectionString, DbProviderFactory provider) {
			ConnectionString = connectionString;
			Provider = provider;
			Json = new DataContractJsonSerializer(new Dictionary<string, string>().GetType());
		}

		public void saveForm(long id, Dictionary<string, string> form) {
			using (var connection = Provider.CreateConnection()) {
				connection.ConnectionString = ConnectionString;
				connection.Open();
				using (var command = Provider.CreateCommand()) {
					command.Connection = connection;
					command.CommandText = "insert into FORMS (FORM_ID, VERSION, ATTRS) values (?, ?, ?::json)";

					var formId = Provider.CreateParameter();
					formId.Value = id;
					command.Parameters.Add(formId);

					var version = Provider.CreateParameter();
					version.Value = 0;
					command.Parameters.Add(version);

					var attrs = Provider.CreateParameter();
					var memstream = new MemoryStream();
					Json.WriteObject(memstream, form);
					var reader = new StreamReader(memstream);
					attrs.Value = reader.ReadToEnd();
					command.Parameters.Add(attrs);

					command.ExecuteNonQuery();
				}
			}
		}
	}
}
