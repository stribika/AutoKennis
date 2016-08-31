using NUnit.Framework;
using System;
using System.Runtime.Serialization.Json;

namespace AutoKennis
{
	[TestFixture]
	public class TestFormDAO
	{
		private volatile DataContractJsonSerializer jsonSerializer = null;

		public DataContractJsonSerializer JsonSerializer {
			get {
				if (jsonSerializer == null) {
					jsonSerializer = new DataContractJsonSerializer(new FormDTO().GetType());
				}

				return jsonSerializer;
			}
		}

		private volatile IFormDAO formDAO = null;

		public IFormDAO FormDAO {
			get {
				if (formDAO == null) {
					formDAO = new FormDAO(
						"Host=localhost;Username=autokennis;Database=autokennis",
						Npgsql.NpgsqlFactory.Instance,
						JsonSerializer
					);
				}

				return formDAO;
			}
		}

		[Test]
		public void TestSaveForm() {
			var form = new FormDTO();
			form.Type = FormType.AankoopBegeleiding;
			form.Fullname = "Tahos Facaj";
			FormDAO.SaveForm(form);
			var forms = FormDAO.LoadActiveForms<FormDTO>(FormType.AankoopBegeleiding);
			Assert.AreEqual(1, forms.Count);
			Assert.AreEqual("Tahos Facaj", forms[0].Fullname);
		}
	}
}

