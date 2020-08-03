using System;
using System.Collections.Generic;
using System.Text;

namespace lsl.LSLTypes
{
    public class Strings
    {
        public string LSLType
        {
            get
            {
                return "string";
            }
        }

        private string value;

        static Strings() { }

        public Strings(string val)
        {
            value = val;
        }

        public override string ToString()
        {
            return "\""+value+"\"";
        }

        public static Strings FromString(string str)
        {
            string V = str;
            if (str.StartsWith('\"') && str.EndsWith('\"'))
            {
                V = V.Remove(0, 1);
                V = V.Remove(V.Length - 1, 1);
            }

            return new Strings(V);
        }
    }
}
