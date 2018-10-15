using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
            double to_convert;
            double converted;
            int menu_option;

            while (cont == "y")
            {
                Console.WriteLine("Welcome to Corban's Lysergic acid " +
                    "diethylamide unit conversion tool.\n" +
                    "To begin conversion plese select from one of the following:\n" +
                    "1. Gallons to quarts.\n" +
                    "2. Quarts to gallons.\n" +
                    "3. Quarts to cups.\n" +
                    "4. Cups to quarts.");

                menu_option = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter amount to convert:");
                to_convert = double.Parse(Console.ReadLine());

                switch (menu_option)
                {
                    //figure out which unit we're converting
                    case 1:
                    case 3:
                        converted = to_convert * 4;
                        Console.WriteLine("Your converted unit is " + converted);
                        break;
                    case 2:
                    case 4:
                        converted = to_convert / 4;
                        Console.WriteLine("Your converted unit is " + converted);
                        break;
                    default:
                        Console.WriteLine("Incorrect menu option. Please try again.");
                        break;
                }

                Console.WriteLine("Would you like to make another conversion? (y/n)");

                cont = Console.ReadLine().ToLower();
            }

            Console.ReadLine();
        }
    }
}

