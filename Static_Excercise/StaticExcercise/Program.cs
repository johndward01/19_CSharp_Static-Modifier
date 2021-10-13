using System;

namespace StaticExcercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface.Welcome();





            string userInput;

            while (true)
            {
                Console.WriteLine("Would you like to convert from Fahrenheit to Celcius?");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    DisplayFahrenheitConversion();
                }
                else
                {
                    DisplayCelciusConversion();
                }

                AddSpaces(2);

                ContinueOrExit(userInput);

                if (userInput == "exit")
                {
                    break;
                }

            }
        }

        public static string ContinueOrExit(string userInput)
        {
            Console.WriteLine("Would you like to continue or exit?");
            Console.Write("Type exit to end the application: ");
            userInput = Console.ReadLine();
            return userInput;            
        }

        public static void DisplayFahrenheitConversion()
        {
            Console.Write("Please enter the degrees in Fahrenheit (whole numbers only): ");
            var fahrenheit = Convert.ToInt32(Console.ReadLine());

            AddSpaces(1);

            Console.Write($"The temperature converted to degrees of Celcius: {TempConverter.FahrenheitToCelcius(fahrenheit)}");
        }

        public static void DisplayCelciusConversion()
        {
            Console.Write("Please enter the degrees in Celcius (whole numbers only): ");
            var celcius = Convert.ToInt32(Console.ReadLine());

            AddSpaces(1);

            Console.Write($"The temperature converted to degrees in Fahrenheit: {TempConverter.CelciusToFahrenheit(celcius)}");
        }

        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces != 0)
            {
                Console.WriteLine();
                numberOfSpaces--;
            }
        }

        
    }
}
