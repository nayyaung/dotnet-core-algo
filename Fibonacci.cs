
using System.Collections.Generic;

public class Fibonacci
{
    public void Print(int n)
    {
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(" " + GetFibonacci(i));
        }
    }

    private int GetFibonacci(int n)
    {
        int sum;
        var cache = new Dictionary<int, int>(); 
        if (n < 2) { return n; }
        if (cache.ContainsKey(n))
        {
            sum = cache[n];
        }
        else
        {
            sum = (n - 1) + (n - 2);
            cache.Add(n, sum);
        }
        return sum; 
    }
}