using System;
using System.Collections.Generic;

namespace AutoKennisWeb {
	public interface IFormDAO {
		long saveForm(FormDTO form);
        //serial, int, jasonb
	}
}