using System;
using System.Collections.Generic;

namespace netcore_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var array = new List<int>();

            array = new List<int>(new int[] { 1, 35, 1, 90, 85, 10, 4, 85, 99, 83, 78 });
            /* To add random integer
            Random rnd = new Random();
            for (int i = 0; i <= 5; i++)
            {
                array.Add(rnd.Next(1, 100));
            }

            System.Console.WriteLine("== Merge Sort ==");
            var sorted = MergeSort.Sort(array);
            System.Console.WriteLine("Before");
            array.ForEach(item => System.Console.Write(item.ToString() + " "));
            System.Console.WriteLine("\nAfter");
            sorted.ForEach(item => System.Console.Write(item.ToString() + " "));

            array = new List<int>(new int[] { 1, 35, 1, 90, 85, 10, 4, 85, 99, 83, 78 }); 
            for (int i = 0; i <= 5; i++)
            {
                array.Add(rnd.Next(1, 100));
            }

            System.Console.WriteLine("\n== Quick Sort ==");
            System.Console.WriteLine("Before");
            array.ForEach(item => System.Console.Write(item.ToString() + " "));
            sorted = QuickSort.Sort(array, 0, array.Count - 1);
            System.Console.WriteLine("\nAfter");
            sorted.ForEach(item => System.Console.Write(item.ToString() + " "));

            var integerToReverse = 11;
            System.Console.WriteLine("\n Reversed Integer of " + integerToReverse + " : " + FlipBit.Flip(integerToReverse));

            integerToReverse = 10;
            System.Console.WriteLine("\n Reversed Integer of " + integerToReverse + " : " + FlipBit.Flip(integerToReverse));

            integerToReverse = 9;
            System.Console.WriteLine("\n Reversed Integer of " + integerToReverse + " : " + FlipBit.Flip(integerToReverse));

            var fibonacciTimes = 13;
            System.Console.WriteLine("\n Printing Fibonacci " + fibonacciTimes + " times");
            new Fibonacci().Print(13);

     */
            NodeTree nt = new NodeTree();
            nt.Test();
        }
    }
}
