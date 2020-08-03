using lsl.Exceptions;
using lsl.LSLTypes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lsl
{
    public class Vector3
    {
        public static string LSLType
        {
            get
            {
                return "vector";
            }
        }


        private double X;
        private double Y;
        private double Z;

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        static Vector3()
        {
        }

        private Vector3(double dX, double dY, double dZ)
        {
            X = dX;
            Y = dY;
            Z = dZ;
        }

        public static Vector3 ZERO_VECTOR {
            get
            {
                return Vector3.FromString("<0,0,0>");
            }
        }

        public static Vector3 FromString(string VectorString)
        {
            string[] splits = VectorString.Split(new char[] { '<', '>', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (splits.Length != 3) throw new CompilationException("Invalid arguments for Vector3, " + VectorString + "; Results in a array size of: " + splits.Length.ToString());
            return new Vector3(Double.Parse(splits[0]), Double.Parse(splits[1]), Double.Parse(splits[2]));
        }

        public Vector3 sub(Vector3 other)
        {
            return new Vector3(X - other.X, Y - other.Y, Z - other.Z);
        }

        public static Float DistanceSum(Vector3 subtracted)
        {
            return new Float(subtracted.X + subtracted.Y + subtracted.Z);
        }

        public Float Distance(Vector3 pos2)
        {
            Vector3 subtracted = sub(pos2);
            return Vector3.DistanceSum(subtracted);
        }
    }
}
