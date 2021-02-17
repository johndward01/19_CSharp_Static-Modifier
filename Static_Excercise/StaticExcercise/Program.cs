using System;

namespace StaticExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TempConverter.FahrenheitToCelcius(32));

            Console.WriteLine(TempConverter.CelciusToFahrenheit(0));

            Console.WriteLine(TempConverter.CelciusToFahrenheit(100));

            Console.WriteLine(TempConverter.FahrenheitToCelcius(212));


        }
    }
}
