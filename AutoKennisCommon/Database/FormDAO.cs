using System;
using System.Data.Common;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Data.SqlClient;

namespace AutoKennis {
	public sealed class FormDAO: IFormDAO {
		private DbProviderFactory Provider { get; set; }

		private string ConnectionString { get; set; }

		private DataContractJsonSerializer Json { get; set; }

		public FormDAO(string connectionString, DbProviderFactory provider, DataContractJsonSerializer json) {
			ConnectionString = connectionString;
			Provider = provider;
            Json = json;
		}

		public void saveAankoopBegeleidingForm(FormDTOExtended form) {
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

        public void saveAankoopKeuringForm(FormDTOExtended form)
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

        public List<FormDTO> LoadFormDTO(string selectedTable)
        {
            List<FormDTO> formRequests = new List<FormDTO>();

            using (var conn = Provider.CreateConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = conn;
                    command.CommandText = $"SELECT id, attrs FROM {selectedTable} WHERE sent = false"; 

                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var memstream = new MemoryStream();
                            var writer = new StreamWriter(memstream);
                            writer.Write(reader.GetString(reader.GetOrdinal("attrs")));
                            writer.Flush();
                            memstream.Position = 0;
                            var formDTO = (FormDTO)Json.ReadObject(memstream);
                            formDTO.id = reader.GetInt64(reader.GetOrdinal("id"));
                            formRequests.Add(formDTO);
                        }
                    }
                }
            }
            return formRequests;
        }


        public List<FormDTOExtended> LoadFormDTOExtended(string selectedTable)
        {
            List<FormDTOExtended> formRequests = new List<FormDTOExtended>();

            using (var conn = Provider.CreateConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = $"SELECT attrs FROM {selectedTable} WHERE SENT = @false";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            formRequests.Add((FormDTOExtended)Json.ReadObject(reader.GetStream(reader.GetOrdinal("attrs"))));
                        }
                    }
                }
            }
            return formRequests;
        }

        public List<string> SetEmailAddresses()
        {
            List<string> addresses = new List<string>();
            using (var conn = Provider.CreateConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT EMAIL FROM EMAILRECEIVERS"; //ide most kellenek parameterek?

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            addresses.Add(reader.GetString(reader.GetOrdinal("email")));
                        }
                    }
                }
            }
            return addresses;
        }

        public void EmailStateSetter(bool isSent, string selectedTable, long ID)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"UPDATE {selectedTable} SET sent = @sent WHERE id = @id";

                    var sent = Provider.CreateParameter();
                    sent.Value = isSent;
                    sent.ParameterName = "@sent";
                    command.Parameters.Add(sent);

                    var id = Provider.CreateParameter();
                    id.Value = ID;
                    id.ParameterName = "@id";
                    command.Parameters.Add(id);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
