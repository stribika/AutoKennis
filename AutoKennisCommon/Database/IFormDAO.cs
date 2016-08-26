﻿using System;
using System.Collections.Generic;

namespace AutoKennis {
	public interface IFormDAO {
		void saveAankoopBegeleidingForm(FormDTOExtended form);
        void saveAankoopKeuringForm(FormDTOExtended form);
        void saveAutoAdviesForm(FormDTO form);
        void saveGarantieKeuringForm(FormDTO form);
        void saveReparatieKeuringForm(FormDTO form);
        List<FormDTO> LoadFormDTO(string selectedTable);
        List<FormDTOExtended> LoadFormDTOExtended(string selectedTable);
        //serial, int, jasonb
        void EmailStateSetter(bool isSent, string selectedTable, long ID);
        List<string> SetEmailAddresses();
    }
}