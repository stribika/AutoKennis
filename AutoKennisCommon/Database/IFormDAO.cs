using System;
using System.Collections.Generic;

namespace AutoKennis {
	public interface IFormDAO {
		void SaveForm(FormDTO form);
		IList<T> LoadActiveForms<T>(FormType formType) where T: FormDTO;
		IList<T> LoadUnsentForms<T>(FormType formType) where T: FormDTO;
		IList<string> GetEmailAddresses();
		void SetEmailSent(FormDTO form, bool sent);
    }
}