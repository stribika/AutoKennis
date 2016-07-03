using System;
using System.Collections.Generic;

namespace AutoKennisWeb {
	public interface IFormDAO {
		void saveAankoopBegeleidingForm(FormDTOExtended form);
        void saveAankoopKeuringForm(FormDTOExtended form);
        void saveAutoAdviesForm(FormDTO form);
        void saveGarantieKeuringForm(FormDTO form);
        void saveReparatieKeuringForm(FormDTO form);
        List<FormDTO> LoadFormDTO(string selectedTable);
        List<FormDTOExtended> LoadFormDTOExtended(string selectedTable);
        //serial, int, jasonb
    }
}