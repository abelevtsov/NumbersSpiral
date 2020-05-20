using System;

namespace NumbersSpiral
{
    /// <summary>
    /// This program calculates sum of numbers placed on diagonals of clockwise squared numbers spiral.
    /// For spiral 5x5 (side size equal 5):
    /// 21 22 23 24 25
    /// 20  7  8  9 10
    /// 19  6  1  2 11
    /// 18  5  4  3 12
    /// 17 16 15 14 13
    /// sum will be: 21 + 7 + 1 + 3 + 13 + 17 + 5 + 9 + 25 = 101
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter spiral side size:");
                var n = Console.ReadLine();
                if (int.TryParse(n, out var number) && number % 2 == 1)
                {
                    Console.WriteLine("Sum is: " + CalcSum(number));
                    Console.WriteLine("For exit press ESC, any key for continue");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You entered invalid side size. Please try again.");
                }
            }
        }

        private static int CalcSum(int n)
        {
            const int trivial = 1;
            if (n == trivial)
            {
                return trivial;
            }

            var sumOfCornerNumbers = n * n * 4 + (1 - n) * 6;

            return sumOfCornerNumbers + CalcSum(n - 2);
        }
    }
}
