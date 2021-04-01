using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExcercise
{
    static class TempConverter
    {
        public static double F = 0;
        public static double C = 0;
        public static double FahrenheitToCelcius(double fTemp)
        {
            return (fTemp - 32) / 1.8000;
        }

        public static double CelciusToFahrenheit(double cTemp)
        {
            return (cTemp * 9 / 5) + 32;
        }
    }
}

