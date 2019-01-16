using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jan19Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            string firstName = nameValid();
            Console.Clear();
            Console.WriteLine("\nHello {0}, Let us display a Squares and Cubes Table of Powers", firstName);
            while (runP == true)
            {
                Console.WriteLine("\nPlease enter an integer");
                int.TryParse(Console.ReadLine(), out int userNum);
                Console.WriteLine("\nNumber       Squared       Cubed");
                Console.WriteLine("======       ======        ======");
                for (int i = 1; i <= userNum; i++)
                {
                    int squared = Square(i);
                    int cubed = Cube(i);
                    Console.WriteLine($"{i}             {squared}             {cubed}");
                }
                runP = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
        private static int Square(int userNum)
        {
            int squNum = userNum * userNum;
            return squNum;
        }
        private static int Cube(int userNum)
        {
            int cubeNum = userNum * userNum * userNum;
            return cubeNum;
        }
        public static string nameValid()
        {
            bool responseValid = true;
            string firstName = "";
            while (responseValid)
            {
                Console.WriteLine("Please enter your first name");
                firstName = Console.ReadLine();

                if (!Regex.IsMatch(firstName, @"^[A-Z]+[A-z]{2,30}$"))
                {
                    Console.WriteLine("I'm sorry, this is not a valid name");
                }
                else
                {
                    Console.WriteLine("Name is valid");
                    break;
                }
            }
            return firstName;
        }
    }
}
