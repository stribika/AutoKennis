using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoKennis
{
    public class NLNameAttribute:System.Attribute
    {
        public readonly string NLName;

		public readonly bool Mandatory;

		public readonly bool SummaryTable;

        public NLNameAttribute(string nlName, bool mandatory = false, bool summaryTable = false)
        {
            NLName       = nlName;
			Mandatory    = mandatory;
			SummaryTable = summaryTable;
        }
    }
}