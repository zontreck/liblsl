using System;
using lsl;
using lsl.LSLTypes;

namespace LibLSL
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vct = Vector3.FromString("<32, 94.2, 9>");
            Float fl = Float.FromString("94.398");

            Console.WriteLine("Vector is: "+vct.ToString());
            Console.WriteLine("Float is: " + fl.ToString());
            Console.WriteLine("String is: " + Strings.FromString("Test string").ToString());
        }
    }
}
