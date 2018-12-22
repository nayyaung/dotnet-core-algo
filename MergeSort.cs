using System.Collections.Generic;
using System.Linq;
using System.Collections;

class MergeSort
{
    public static List<int> Sort(List<int> unsortedArray)
    {
        if (unsortedArray.Count <= 1) { return unsortedArray; }

        var mid = unsortedArray.Count / 2;
        var left = Sort(unsortedArray.Take(mid).ToList());
        var right = Sort(unsortedArray.Skip(mid).ToList());

        var i = 0;
        var j = 0;
        var sorted = new List<int>();
        while (i < left.Count && j < right.Count)
        {
            if (left[i] < right[j])
            {
                sorted.Add(left[i]);
                i++;
            }
            else
            {
                sorted.Add(right[j]);
                j++;
            }
        }

        for (; i < left.Count; i++)
        {
            sorted.Add(left[i]);
        }
        for (; j < right.Count; j++)
        {
            sorted.Add(right[j]);
        }

        return sorted.ToList();
    }
}