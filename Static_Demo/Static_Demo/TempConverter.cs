using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Demo
{
    public static class TempConverter
    {
        // Static Fields
        public static int Id;

        // Static Props
        public static int MyProperty { get; set; }

        // Static Constructor
        static TempConverter()
        {

        }

        // Static Methods
        public static void PrintTemp(string temp)
        {
            Console.WriteLine($"The temp is {temp}.");
        }
    }
}
