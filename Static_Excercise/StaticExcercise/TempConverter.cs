using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExcercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}

