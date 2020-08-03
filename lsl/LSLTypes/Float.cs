using System;
using System.Collections.Generic;
using System.Text;

namespace lsl.LSLTypes
{
    public class Float
    {
        public static string LSLType
        {
            get
            {
                return "float";
            }
        }

        private double value; // Floats in LSL are more accurately called doubles.

        static Float() { }

        public Float(double FloatVal)
        {
            value = FloatVal;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public static Float FromString(string FloatValue)
        {
            return new Float(Double.Parse(FloatValue));
        }
    }


}
