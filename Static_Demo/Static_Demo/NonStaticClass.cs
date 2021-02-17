using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Demo
{
    class NonStaticClass 
    {
        private static readonly DateTime _date;

        public int Age { get; set; }

        public DateTime Date { get; set; }

        static NonStaticClass()
        {
            _date = DateTime.Now;
        }

        public static void SetDate(DateTime date)
        {
            var n = new NonStaticClass();
            n.Date = date;
        }
    }
}
