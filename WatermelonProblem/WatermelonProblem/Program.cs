using System;

namespace WatermelonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int number = Int32.Parse(input);
            if (number % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");

            }
        }
    }
}
