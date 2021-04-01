using System;

namespace StaticExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            UserInterface.Welcome();

            while (input != "exit")
            {

                UserInterface.PromptUserForKeyPress();

                Console.Write("What would you like to convert to: ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "f":
                        var fTemp = UserInterface.PromptUserForFTemp();
                        var convertedTemp = TempConverter.FahrenheitToCelcius(fTemp);
                        Console.WriteLine($"The temperature in Celcius is: {convertedTemp}");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    case "c":
                        var cTemp = UserInterface.PromptUserForCTemp();
                        convertedTemp = TempConverter.CelciusToFahrenheit(cTemp);
                        Console.WriteLine($"The temperature in Fahrenheit is: {convertedTemp}");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    default: 
                        Console.WriteLine("Command not recognized...");
                        break;
                }
            }

        }

        
    }
}
