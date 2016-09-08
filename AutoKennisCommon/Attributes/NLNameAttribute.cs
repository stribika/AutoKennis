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

        public NLNameAttribute(string nlName, bool mandatory = false)
        {
            NLName       = nlName;
			Mandatory    = mandatory;
        }
    }
}