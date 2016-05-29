using System;
using System.Collections.Generic;

namespace AutoKennisWeb {
	public interface IFormDAO {
		void saveAankoopBegeleidingForm(FormDTO form);
        void saveAankoopKeuringForm(FormDTO form);
        void saveAutoAdviesForm(FormDTO form);
        void saveGarantieKeuringForm(FormDTO form);
        void saveReparatieKeuringForm(FormDTO form);
        //serial, int, jasonb
    }
}