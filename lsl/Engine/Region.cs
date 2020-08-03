using System;
using System.Collections.Generic;
using System.Text;

namespace lsl.Engine
{
    public class Region
    {
        // This class should contain the list of objects, and some basic methods for handling the say methods
        private string RegionName;
        private int SimPosX;
        private int SimPosY;

        public Region(string Name, int GPosX, int GPosY)
        {
            RegionName = Name;
            SimPosX = GPosX;
            SimPosY = GPosY;

            Console.WriteLine("New region created: " + RegionName);
            Console.WriteLine("Initializing variables...");
        }
    }
}
