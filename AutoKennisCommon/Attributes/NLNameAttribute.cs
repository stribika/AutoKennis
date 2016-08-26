using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoKennisWeb
{
    public class NLNameAttribute:System.Attribute
    {
        public readonly string NLName;

        public NLNameAttribute(string nlName)
        {
            NLName = nlName;
        }
    }
}