using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Demo
{
    public class NonStaticClass 
    {
        public int Balance { get; set; } // non static member
        public static int StaticBalance { get; set; } // static member
    }
}
