using AutoKennis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Reflection;

namespace AutoKennisWeb
{
    public class ReportEditor
    {
        //string startPath = @"C:\Users\Eigenaar\Downloads\ReportExample.docx";
        //string extractPath = @"C:\Users\Eigenaar\Downloads\Xmlek";
        //string zipPath = @"C:\Users\Eigenaar\Downloads\TestReport.docx";

        public void CreateDocx<T>(string startPath, string extractPath, string zipPath, T formDTO) where T: FormDTO
        {
            ZipFile.ExtractToDirectory(startPath, extractPath);

            XmlDocument editedDoc = new XmlDocument();
            editedDoc.LoadXml(EditXml(extractPath + @"\word\document.xml", formDTO));
            editedDoc.Save("document.xml");

            File.Replace("document.xml", extractPath + @"\word\document.xml", "backup.xml");

            //file replace a kepeket is kesobb

            ZipFile.CreateFromDirectory(extractPath, zipPath);
        }

        private string EditXml<T>(string xmlPath, T formDTO) where T: FormDTO
        {
            string xml = File.ReadAllText(xmlPath);
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
				var placeholder = $"${property.GetCustomAttribute<NLNameAttribute>().NLName}";
				var escapedValue = EscapeXml(property.GetValue(formDTO)?.ToString());
				xml = xml.Replace(placeholder, escapedValue);
            }

            return xml;
        }

		private static string EscapeXml(string unescaped)
		{
			XmlDocument doc = new XmlDocument();
			XmlNode node = doc.CreateElement("root");
			node.InnerText = unescaped;
			return node.InnerXml;
		}

        private string licencePlateOpt(string licenceplate)
        {

            var licenceplateChars = ((licenceplate.ToUpper()).ToCharArray()).ToList();
            List<char> licPlateResult = new List<char>();
            bool former = char.IsDigit(licenceplateChars[0]);

            if (licenceplateChars.Contains('-'))
            {
                for (int i = 0; i < licenceplateChars.Count; i++)
                {
                    licPlateResult.Add(licenceplateChars[i]);
                }
            }
            else if ((char.IsDigit(licenceplateChars[0]) == char.IsDigit(licenceplateChars[1])) && (char.IsDigit(licenceplateChars[4]) == char.IsDigit(licenceplateChars[5])))
            {
                licPlateResult.Add(licenceplateChars[0]);
                for (int i = 1; i < licenceplateChars.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        licPlateResult.Add('-');
                    }
                    licPlateResult.Add(licenceplateChars[i]);
                }
            }
            else
            {
                for (int i = 0; i < licenceplateChars.Count; i++)
                {
                    if (char.IsDigit(licenceplateChars[i]) != former)
                    {
                        licPlateResult.Add('-');
                        former = char.IsDigit(licenceplateChars[i]);
                    }
                    licPlateResult.Add(licenceplateChars[i]);

                }
            }
            return string.Join("", licPlateResult.ToArray());
        }

    }
}