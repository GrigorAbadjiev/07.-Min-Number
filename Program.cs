using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double minNumber = double.MaxValue;

            while (input != "Stop")
            {
                double inputAsNumber = double.Parse(input);

                if (inputAsNumber < minNumber)
                {
                    minNumber = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
