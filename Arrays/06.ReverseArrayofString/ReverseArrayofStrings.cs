using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayofString
{
    class ReverseArrayofStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
