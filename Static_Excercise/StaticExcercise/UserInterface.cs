using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExcercise
{
    static class UserInterface
    {
        public static void Welcome() 
        {
            Console.WriteLine("TEMP CONVERTER");
            Console.WriteLine();
            Console.WriteLine("Type 'exit' to exit the program.");
            Console.WriteLine();
        }

        public static double PromptUserForFTemp()
        {
            Console.WriteLine();
            Console.Write("Temperature in Fahrenheit: ");
            var fTemp = Convert.ToDouble(Console.ReadLine());
            return fTemp;
        }

        public static double PromptUserForCTemp()
        {
            Console.WriteLine();
            Console.Write("Temperature in Celcius: ");
            var cTemp = Convert.ToDouble(Console.ReadLine());
            return cTemp;
        }

        public static void PromptUserForKeyPress()
        {
            Console.WriteLine("To Convert from Celcius to Fahrenheit type the letter 'c'");
            Console.WriteLine("To Convert from Fahrenheit to Celcius type the letter 'f'");
            Console.WriteLine();
        }

        public static void ShowConvertedFahrenheitTemp(double convertedTemp)
        {
            Console.WriteLine($"The temperature in Fahrenheit is: {convertedTemp}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ShowConvertedCelciusTemp(double convertedTemp)
        {
            Console.WriteLine($"The temperature in Fahrenheit is: {convertedTemp}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
