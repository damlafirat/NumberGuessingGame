using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();

            Console.ReadLine();
        }

        private static void playGame()
        {
            int num = generateNumber();
            int right = 10;
            string line;

            Console.Write("Enter a number : ");
            line = Console.ReadLine();

            while (true)
            {
                if (checkValue(line))
                {
                    if (int.Parse(line) > num)
                    {
                        Console.WriteLine($"You have {right} right...");
                        Console.Write("Enter a  smaller number : ");
                        line = Console.ReadLine();
                        right--;
                    }

                    else if (int.Parse(line) < num)
                    {
                        Console.WriteLine($"You have {right} right...");
                        Console.Write("Enter a  larger number : ");
                        line = Console.ReadLine();
                        right--;
                    }

                    else if (num == int.Parse(line))
                    {
                        Console.WriteLine("You won!");
                        break;
                    }

                    if (right == 0 && num != int.Parse(line))
                    {
                        Console.WriteLine("You lost!");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }

            Console.WriteLine($"Number is {num}");
        }

        private static bool checkValue(string line)
        {
            int result;

            if (int.TryParse(line, out result))
                return true;

            else
                return false;
        }

        private static int generateNumber()
        {
            Random rnd = new Random();

            return rnd.Next(0, 100);
        }
    }
}
