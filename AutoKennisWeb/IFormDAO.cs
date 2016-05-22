using System;
using System.Collections.Generic;

namespace AutoKennisWeb {
	public interface IFormDAO {
		void saveForm(long id, Dictionary<string, string> form);
	}
}