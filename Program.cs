using System;
using System.Collections.Generic;

namespace netcore_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>();
            // instantiate an array with random integer
            array = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                array.Add(rnd.Next(1, 100));
            }
            var sorted = MergeSort.Sort(array);
            System.Console.WriteLine("Before");
            array.ForEach(item => System.Console.Write(item.ToString() + " "));
            System.Console.WriteLine("\nAfter");
            sorted.ForEach(item => System.Console.Write(item.ToString() + " "));
        }
    }
}
