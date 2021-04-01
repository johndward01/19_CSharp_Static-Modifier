using System;

namespace StaticExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double convertedTemp;
            double fTemp;
            double cTemp;

            UserInterface.Welcome();

            while (input != "exit")
            {

                UserInterface.PromptUserForKeyPress();

                Console.Write("What would you like to convert to: ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "f":
                        fTemp = UserInterface.PromptUserForFTemp();
                        convertedTemp = TempConverter.FahrenheitToCelcius(fTemp);
                        UserInterface.ShowConvertedCelciusTemp(convertedTemp);
                        break;
                    case "c":
                        cTemp = UserInterface.PromptUserForCTemp();
                        convertedTemp = TempConverter.CelciusToFahrenheit(cTemp);
                        UserInterface.ShowConvertedFahrenheitTemp(convertedTemp);
                        break;
                    default: 
                        Console.WriteLine("Command not recognized...");
                        break;
                }
            }

        }

        
    }
}
