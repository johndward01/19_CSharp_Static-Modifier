using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Demo
{
    public static class StaticClass
    {
        public static int Balance { get; set; } = 100;

        public static int MyProperty { get; set; }        

        public static void StaticMethod()
        {
            Console.WriteLine("I am a static method");
        }


    }
}
