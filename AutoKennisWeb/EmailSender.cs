using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Web;

namespace AutoKennisWeb
{
    public class EmailSender
    {
        private DbProviderFactory Provider { get; set; }
        private string ConnString { get; set; }
        private DataContractJsonSerializer Json { get; set; }
        private string from = "afspraak@auto-kennis.nl";


        public string BodyBuilderFormDTO(string formtype, FormDTO formDTO)
        {
            FormDAO fDAO = new FormDAO(ConnString, Provider);

            string body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";


            PropertyInfo[] properties = typeof(FormDTO).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                body = body + $"{property.GetCustomAttribute<NLNameAttribute>().NLName}   {property.GetValue(formDTO)}{Environment.NewLine}";
            }

            body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";


            return body;
        }

        public string BodyBuilderFormDTOExtended(string formtype, FormDTOExtended formDTO)
        {
            FormDAO fDAO = new FormDAO(ConnString, Provider);
            string body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";

            PropertyInfo[] properties = typeof(FormDTOExtended).GetProperties();

            foreach (PropertyInfo property in properties)
            {

                body = body + $"{property.GetCustomAttribute<NLNameAttribute>().NLName}   {property.GetValue(formDTO)}{Environment.NewLine}";

            }

            body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";


            return body;
        }

        public List<string> SetEmailAddresses()
        {
            List<string> addresses = new List<string>();
            using (var conn = Provider.CreateConnection())
            {
                conn.ConnectionString = ConnString;
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


        public bool MailSend(string server, List<string> emailAddresses, string body, string formtype)
        {
            try
            {
                MailMessage msg = new MailMessage();

                foreach (string item in emailAddresses)
                {
                    msg.To.Add(item);
                }
                msg.From = new MailAddress(from);
                msg.Subject = "Afspraak " + formtype;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient(server);
                smtp.Port = 25;

                //smtp.EnableSsl = true;

                smtp.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void EmailStateSetter(bool isSent, string selectedTable, long ID)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnString;
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
                }
            }
        }
    }
}