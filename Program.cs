using System;
using System.Collections.Generic;

namespace netcore_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int>();
            
            array.Add(2);
            array.Add(5);
            array.Add(1);
            array.Add(6);
            array.Add(3);
            array.Add(4);
            var sorted = MergeSort.Sort(array);
            System.Console.WriteLine("Before");
            array.ForEach(item => System.Console.Write(item.ToString() + " "));
            System.Console.WriteLine("\nAfter");
            sorted.ForEach(item => System.Console.Write(item.ToString() + " "));

            System.Console.WriteLine("\nWith random integers");
            array = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                array.Add(rnd.Next(1, 9));
            }
            sorted = MergeSort.Sort(array);
            System.Console.WriteLine("Before");
            array.ForEach(item => System.Console.Write(item.ToString() + " "));
            System.Console.WriteLine("\nAfter");
            sorted.ForEach(item => System.Console.Write(item.ToString() + " "));
        }
    }
}
