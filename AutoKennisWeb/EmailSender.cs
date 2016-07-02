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
 

        public List<string> BodyBuilderFormDTO(string formtype, string selectedTable)
        {
            FormDAO fDAO = new FormDAO(ConnString, Provider);
            List<FormDTO> formList = fDAO.LoadFormDTO(selectedTable);
            string body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";

            List<string> outputList = new List<string>();

            PropertyInfo[] properties = typeof(FormDTO).GetProperties();

            foreach (var item in formList)
            {

                foreach (PropertyInfo property in properties)
                {
                    
                    body = body + $"{property.GetCustomAttribute<NLNameAttribute>().NLName}   {property.GetValue(item)}{Environment.NewLine}";

                }

                outputList.Add(body);
                body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";
            }

            return outputList;
        }

        public List<string> BodyBuilderFormDTOExtended(string formtype, string selectedTable)
        {
            FormDAO fDAO = new FormDAO(ConnString, Provider);
            List<FormDTOExtended> formList = fDAO.LoadFormDTOExtended(selectedTable);
            string body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";

            List<string> outputList = new List<string>();

            PropertyInfo[] properties = typeof(FormDTOExtended).GetProperties();

            foreach (var item in formList)
            {

                foreach (PropertyInfo property in properties)
                {

                    body = body + $"{property.GetCustomAttribute<NLNameAttribute>().NLName}   {property.GetValue(item)}{Environment.NewLine}";

                }

                outputList.Add(body);
                body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";
            }

            return outputList;
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


        public bool GarantieKeuringMailSend(string server, List<string> emailAddresses, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();

                foreach (string item in emailAddresses)
                {
                    msg.To.Add(item);
                }
                msg.From = new MailAddress(from);
                msg.Subject = "Afspraak Garantie-Keuring";
                msg.Body = body;
                SmtpClient smtp = new SmtpClient(server);

                //smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("username", "password");
                smtp.EnableSsl = true;

                smtp.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AankoopKeuringMailSend(string server, string emailAddress, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();

                msg.To.Add(emailAddress);
                msg.Subject = "Afspraak Aankoop-Keuring";
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AankoopBegeleidingMailSend(string server, string emailAddress, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();

                msg.To.Add(emailAddress);
                msg.Subject = "Afspraak Aankoop-Begeleiding";
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AutoAdviesMailSend(string server, string emailAddress, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();

                msg.To.Add(emailAddress);
                msg.Subject = "Afspraak Auto-Advies";
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ReparatieKeuringMailSend(string server, string emailAddress, string body)
        {
            try
            {
                MailMessage msg = new MailMessage();

                msg.To.Add(emailAddress);
                msg.Subject = "Afspraak Reparatie-Keuring";
                msg.Body = body;
                SmtpClient smtp = new SmtpClient();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void EmailStateSetter(bool isSent, string selectedTable)
        {
            using (var connection = Provider.CreateConnection())
            {
                connection.ConnectionString = ConnString;
                connection.Open();
                using (var command = Provider.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"UPDATE {selectedTable} SET sent = {isSent}";
                }
            }
        }
    }
}