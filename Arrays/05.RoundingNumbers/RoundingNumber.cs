using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class RoundingNumber
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double a = numbers[i];
                
                int c = (int)Math.Floor(numbers[i]);

                if (a<0)
                {
                    Console.WriteLine($"{numbers[i]} => {c}");
                }
                else
                {
                    int b = (int)Math.Truncate(a+0.5);            
                    Console.WriteLine($"{numbers[i]} => {b}");
                }
                
            }

        }
    }
}
