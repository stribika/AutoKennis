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

        public void SaveForm(FormDTO form)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
					command.CommandText = $"insert into {form.Type.GetTableName()} (VERSION, ATTRS) values (@V, @A::json)";
					command.SetParameter("V", 0);
					var memstream = new MemoryStream();
					Json.WriteObject(memstream, form);
					memstream.Position = 0;
					var reader = new StreamReader(memstream);
					command.SetParameter("A", reader.ReadToEnd());
                    command.ExecuteNonQuery();
                }
            }
        }

		public IList<T> LoadActiveForms<T>(FormType formType) where T: FormDTO
		{
			using (var conn = Provider.CreateConnection()) {
				conn.ConnectionString = ConnectionString;
				conn.Open();
				return conn.Query($"SELECT Id, Attrs FROM {formType.GetTableName()} WHERE Status = 'Active'", (reader) => ReadFormDTO<T>(reader, formType));
			}
		}

		public IList<T> LoadUnsentForms<T>(FormType formType) where T: FormDTO
        {
            using (var conn = Provider.CreateConnection())
            {
                conn.ConnectionString = ConnectionString;
                conn.Open();
				return conn.Query($"SELECT Id, Attrs FROM {formType.GetTableName()} WHERE Sent = false", (reader) => ReadFormDTO<T>(reader, formType));
            }
		}

		private T ReadFormDTO<T>(DbDataReader reader, FormType formType) where T: FormDTO {
			var memstream = new MemoryStream();
			var writer = new StreamWriter(memstream);
			writer.Write(reader.GetString(reader.GetOrdinal("attrs")));
			writer.Flush();
			memstream.Position = 0;
			var formDTO = (T)Json.ReadObject(memstream);
			formDTO.id = reader.GetInt64(reader.GetOrdinal("id"));
			formDTO.Type = formType;
			return formDTO;
		}

        public IList<string> GetEmailAddresses()
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

        public void SetEmailSent(FormDTO form, bool sent)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
					command.CommandText = $"UPDATE {form.Type.GetTableName()} SET sent = @sent WHERE id = @id";
					command.SetParameter("sent", sent);
					command.SetParameter("id", form.id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
