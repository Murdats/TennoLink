using System;
using System.Linq;

namespace TennoLink.Utils
{
    public class IdentifierAttribute : Attribute
    {
        public string Value { get; set; }

        public IdentifierAttribute(string value)
        {
            Value = value;
        }
    }
}