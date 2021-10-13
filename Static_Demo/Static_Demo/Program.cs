using System;

namespace Static_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n1 = new NonStaticClass();
            var n2 = new NonStaticClass();
            n1.Balance = 200;
            n2.Balance = 2000;

            NonStaticClass.StaticBalance = 100;


            TempConverter.PrintTemp("Very cold temp");
            TempConverter.Id = 10;

        }

    }
}
