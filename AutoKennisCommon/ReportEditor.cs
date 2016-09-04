using AutoKennis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Reflection;

namespace AutoKennis
{
	public class ReportEditor: IDisposable, IReportEditor
	{
		internal static readonly string PathInDocx = Path.Combine("word", "document.xml");

		private readonly string DocxTemplatePath;

		private readonly string DocumentXmlTemplatePath = Path.GetTempFileName();

		public ReportEditor(string docxTemplatePath)
		{
			DocxTemplatePath = docxTemplatePath;

			using (var templateStream = new FileStream(DocxTemplatePath, FileMode.Open, FileAccess.Read)) {
				using (var templateZip = new ZipArchive(templateStream, ZipArchiveMode.Read)) {
					var entryToExtract = templateZip.GetEntry(PathInDocx);
					entryToExtract.ExtractToFile(DocumentXmlTemplatePath, overwrite: true);
				}
			}
		}

		~ReportEditor() {
			Dispose();
		}

		public void Dispose() {
			File.Delete(DocumentXmlTemplatePath);
		}

		public string CreateDocx(object formDTO)
		{
			var documentXmlReportPath = CreateDocumentXml(formDTO);
			try {
				var docxReportPath = Path.GetTempFileName();
				File.Copy(DocxTemplatePath, docxReportPath, overwrite: true);
				using (var docxReportStream = new FileStream(docxReportPath, FileMode.Open, FileAccess.ReadWrite)) {
					using (var docxReportZip = new ZipArchive(docxReportStream, ZipArchiveMode.Update)) {
						docxReportZip.GetEntry(PathInDocx).Delete();
						docxReportZip.CreateEntryFromFile(documentXmlReportPath, PathInDocx);
					}
				}
				return docxReportPath;
			} finally {
				File.Delete(documentXmlReportPath);
			}
		}

        private string CreateDocumentXml(object formDTO)
        {
			var documentXmlReportPath = Path.GetTempFileName();

			string xml = File.ReadAllText(DocumentXmlTemplatePath);
			PropertyInfo[] properties = formDTO.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
				var placeholder = $"${{{property.GetCustomAttribute<NLNameAttribute>().NLName}}}";
				var escapedValue = EscapeXml(property.GetValue(formDTO)?.ToString());
				xml = xml.Replace(placeholder, escapedValue);
            }

			File.WriteAllText(documentXmlReportPath, xml);
            return documentXmlReportPath;
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