using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseInts
{
    class ReverseInts
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];

            for (int i = 0; i < num; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine()); 
            }

            for (int i = num-1; i >= 0; i--)
            {
                Console.WriteLine("{0}", arr1[i]);          
            }
        }
    }
}
