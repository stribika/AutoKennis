using NUnit.Framework;
using System;
using System.IO;
using System.IO.Compression;
using System.Xml;

namespace AutoKennis
{
	[TestFixture]
	public class TestReportEditor
	{
		private class Foo {
			[NLName("name")]
			public string Name { get; set; }
		}

		private readonly IReportEditor reportEditor = new ReportEditor(Path.Combine(
			TestContext.CurrentContext.TestDirectory,
			"..",
			"..",
			"TestData",
			"template.docx"
		));

		[Test]
		public void TestCreateDocxGood()
		{
			var foo = new Foo();
			foo.Name = "Hello World!";
			var docxReportPath = reportEditor.CreateDocx(foo);

			try {
				using (var docxReportStream = new FileStream(docxReportPath, FileMode.Open, FileAccess.Read)) {
					using (var docxReportZip = new ZipArchive(docxReportStream, ZipArchiveMode.Read)) {
						using (var documentXmlStream = docxReportZip.GetEntry(ReportEditor.PathInDocx).Open()) {
							using (var documentXmlReader = new StreamReader(documentXmlStream)) {
								StringAssert.Contains(foo.Name, documentXmlReader.ReadToEnd(), foo.Name);
							}
						}
					}
				}
			} finally {
				File.Delete(docxReportPath);
			}
		}

		[Test]
		public void TestCreateDocxBad()
		{
			var foo = new Foo();
			foo.Name = "<hello>world</hello>";
			var docxReportPath = reportEditor.CreateDocx(foo);

			try {
				using (var docxReportStream = new FileStream(docxReportPath, FileMode.Open, FileAccess.Read)) {
					using (var docxReportZip = new ZipArchive(docxReportStream, ZipArchiveMode.Read)) {
						using (var documentXmlStream = docxReportZip.GetEntry(ReportEditor.PathInDocx).Open()) {
							var xml = new XmlDocument();
							xml.Load(documentXmlStream);
							Assert.AreEqual(1, xml.GetElementsByTagName("w:document").Count);
							Assert.AreEqual(1, xml.GetElementsByTagName("w:body").Count);
							Assert.AreEqual(0, xml.GetElementsByTagName("hello").Count);
						}
					}
				}
			} finally {
				File.Delete(docxReportPath);
			}
		}

		[Test]
		public void TestCreateDocxUgly()
		{
			var foo = new Foo();
			foo.Name = "<hello><world></hello></world><!-- --";
			var docxReportPath = reportEditor.CreateDocx(foo);

			try {
				using (var docxReportStream = new FileStream(docxReportPath, FileMode.Open, FileAccess.Read)) {
					using (var docxReportZip = new ZipArchive(docxReportStream, ZipArchiveMode.Read)) {
						using (var documentXmlStream = docxReportZip.GetEntry(ReportEditor.PathInDocx).Open()) {
							var xml = new XmlDocument();
							xml.Load(documentXmlStream); // no exception
							Assert.AreEqual(1, xml.GetElementsByTagName("w:document").Count);
							Assert.AreEqual(1, xml.GetElementsByTagName("w:body").Count);
						}
					}
				}
			} finally {
				File.Delete(docxReportPath);
			}
		}
	}
}
