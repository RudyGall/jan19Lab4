using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jan19Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            Console.WriteLine("Squares and Cubes");
            while (runP == true)
            {
                Console.WriteLine("\nEnter an integer");
                //int userNum = int.Parse(Console.ReadLine());
                int.TryParse(Console.ReadLine(), out int userNum);
                Console.WriteLine("Number       Squared       Cubed");
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
    }
}
