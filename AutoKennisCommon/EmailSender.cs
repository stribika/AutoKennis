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

namespace AutoKennis
{
    public class EmailSender
    {
        private IFormDAO FormDAO { get; set; }
        private DataContractJsonSerializer Json { get; set; }
        private string from = "afspraak@auto-kennis.nl";

        public EmailSender(IFormDAO formDAO, DataContractJsonSerializer jsonSerializer)
        {
            FormDAO = formDAO;
            Json = jsonSerializer;
        }

        public string BodyBuilderFormDTO(FormDTO formDTO)
        {
			string body = $"De volgende aanvraag {formDTO.Type.GetDescription()} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";


            PropertyInfo[] properties = typeof(FormDTO).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var name = property.GetCustomAttribute<NLNameAttribute>();
                if (name != null)
                {
                    body = body + $"{name.NLName}   {property.GetValue(formDTO)}{Environment.NewLine}";
                }
            }

            return body;
        }

        public string BodyBuilderFormDTOExtended(string formtype, FormDTOExtended formDTO)
        {
            string body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";

            PropertyInfo[] properties = typeof(FormDTOExtended).GetProperties();

            foreach (PropertyInfo property in properties)
            {

                body = body + $"{property.GetCustomAttribute<NLNameAttribute>().NLName}   {property.GetValue(formDTO)}{Environment.NewLine}";

            }

            body = $"De volgende aanvraag {formtype} werd ingediend,{Environment.NewLine}{Environment.NewLine}Gegevens:{Environment.NewLine}";


            return body;
        }




        public bool MailSend(string server, IList<string> emailAddresses, string body, string formtype, string customerEmail)
        {
            try
            {
                MailMessage msg = new MailMessage();

                foreach (string item in emailAddresses)
                {
                    msg.To.Add(item);
                }
                msg.To.Add(customerEmail);
                msg.From = new MailAddress(from);
                msg.Subject = "Afspraak " + formtype;
                msg.Body = body;
                SmtpClient smtp = new SmtpClient(server);
                smtp.Port = 80;

                //smtp.EnableSsl = true;

                smtp.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
