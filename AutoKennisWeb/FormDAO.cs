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
			Json = new DataContractJsonSerializer(new FormDTO().GetType());
		}

		public void saveAankoopBegeleidingForm(FormDTO form) {
			using (var connection = Provider.CreateConnection()) {
				connection.ConnectionString = ConnectionString;
				connection.Open();
				using (var command = Provider.CreateCommand()) {
					command.Connection = connection;
					command.CommandText = "insert into AankoopBegeleidingForm (VERSION, ATTRS) values (@V, @A::json)";

					//var formId = Provider.CreateParameter();
					//formId.Value = id;
					//command.Parameters.Add(formId);

					var version = Provider.CreateParameter();
					version.Value = 0;
                    version.ParameterName = "@V";
					command.Parameters.Add(version);

					var attrs = Provider.CreateParameter();
					var memstream = new MemoryStream();
					Json.WriteObject(memstream, form);
                    memstream.Position = 0;
					var reader = new StreamReader(memstream);
					attrs.Value = reader.ReadToEnd();
                    attrs.ParameterName = "@A";
					command.Parameters.Add(attrs);

					command.ExecuteNonQuery();
				}
			}
		}

        public void saveAankoopKeuringForm(FormDTO form)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into AankoopKeuringForm (VERSION, ATTRS) values (@V, @A::json)";

                    //var formId = Provider.CreateParameter();
                    //formId.Value = id;
                    //command.Parameters.Add(formId);

                    var version = Provider.CreateParameter();
                    version.Value = 0;
                    version.ParameterName = "@V";
                    command.Parameters.Add(version);

                    var attrs = Provider.CreateParameter();
                    var memstream = new MemoryStream();
                    Json.WriteObject(memstream, form);
                    memstream.Position = 0;
                    var reader = new StreamReader(memstream);
                    attrs.Value = reader.ReadToEnd();
                    attrs.ParameterName = "@A";
                    command.Parameters.Add(attrs);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void saveAutoAdviesForm(FormDTO form)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into AutoAdviesForm (VERSION, ATTRS) values (@V, @A::json)";

                    //var formId = Provider.CreateParameter();
                    //formId.Value = id;
                    //command.Parameters.Add(formId);

                    var version = Provider.CreateParameter();
                    version.Value = 0;
                    version.ParameterName = "@V";
                    command.Parameters.Add(version);

                    var attrs = Provider.CreateParameter();
                    var memstream = new MemoryStream();
                    Json.WriteObject(memstream, form);
                    memstream.Position = 0;
                    var reader = new StreamReader(memstream);
                    attrs.Value = reader.ReadToEnd();
                    attrs.ParameterName = "@A";
                    command.Parameters.Add(attrs);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void saveGarantieKeuringForm(FormDTO form)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into GarantieKeuringForm (VERSION, ATTRS) values (@V, @A::json)";

                    //var formId = Provider.CreateParameter();
                    //formId.Value = id;
                    //command.Parameters.Add(formId);

                    var version = Provider.CreateParameter();
                    version.Value = 0;
                    version.ParameterName = "@V";
                    command.Parameters.Add(version);

                    var attrs = Provider.CreateParameter();
                    var memstream = new MemoryStream();
                    Json.WriteObject(memstream, form);
                    memstream.Position = 0;
                    var reader = new StreamReader(memstream);
                    attrs.Value = reader.ReadToEnd();
                    attrs.ParameterName = "@A";
                    command.Parameters.Add(attrs);

                    command.ExecuteNonQuery();
                }
            }
        }


        public void saveReparatieKeuringForm(FormDTO form)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into ReparatieKeuringForm (VERSION, ATTRS) values (@V, @A::json)";

                    //var formId = Provider.CreateParameter();
                    //formId.Value = id;
                    //command.Parameters.Add(formId);

                    var version = Provider.CreateParameter();
                    version.Value = 0;
                    version.ParameterName = "@V";
                    command.Parameters.Add(version);

                    var attrs = Provider.CreateParameter();
                    var memstream = new MemoryStream();
                    Json.WriteObject(memstream, form);
                    memstream.Position = 0;
                    var reader = new StreamReader(memstream);
                    attrs.Value = reader.ReadToEnd();
                    attrs.ParameterName = "@A";
                    command.Parameters.Add(attrs);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
