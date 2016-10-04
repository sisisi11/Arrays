using System;


namespace _01.DaysOfWeeks
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = {"Monday", "Thursday", "Wednesday"};

            if (n >= 1 && n <= 3)
            {
                Console.WriteLine(arr[n - 1]);
            }
            else

            {
                Console.WriteLine("Mistake");
            }
        }
    }
}
