using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.IO.Compression;
using System.Xml;

namespace AutoKennisWeb
{
    public class ReportEditor
    {
        //string startPath = @"C:\Users\Eigenaar\Downloads\ReportExample.docx";
        //string extractPath = @"C:\Users\Eigenaar\Downloads\Xmlek";
        //string zipPath = @"C:\Users\Eigenaar\Downloads\TestReport.docx";

        public void docXcreator(string startPath, string extractPath, string zipPath)
        {
            ZipFile.ExtractToDirectory(startPath, extractPath);

            XmlDocument editedDoc = new XmlDocument();
            editedDoc.LoadXml(editXml(extractPath + @"\word\document.xml"));
            editedDoc.Save("document.xml");

            File.Replace("document.xml", extractPath + @"\word\document.xml", "backup.xml");

            ZipFile.CreateFromDirectory(extractPath, zipPath);
        }

		private string editXml(string xmlPath, Dictionary<string, string> parameters)
        {
            string xml = File.ReadAllText(xmlPath);

			foreach (var param in parameters) {
				xml = xml.Replace("$({" + param.Key + "})", param.Value);
			}
            xml = xml.Replace("$({Name})", "Test Name").Replace("$({reportDate})", DateTime.Today.ToString());
            xml = xml.Replace("$({carType})", "Test Type").Replace("$({carLicensePlate})", "Test Licenceplate");
            xml = xml.Replace("$({carKm})", "Test km").Replace("$({carYear})", "Test Year").Replace("$({carPrice})", "Test price");
            xml = xml.Replace("$({cst})", "Test cost").Replace("$({km})", "$({km})").Replace("$({ttc})", "$({ttc})");
            xml = xml.Replace("$({carHistory})", "Test history");

            return xml;
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