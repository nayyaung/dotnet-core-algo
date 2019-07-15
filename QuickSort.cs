using System.Collections;
using System.Collections.Generic;
using System.Linq;

class QuickSort {

    private static int Partition (List<int> unsortedArray, int firstIndex, int lastIndex) {
        var pivot = firstIndex;
        var done = false;
        var i = pivot + 1;
        var j = lastIndex;
        var swap = 0;
        while (!done) {
            while (i <= j && unsortedArray[i] <= unsortedArray[pivot]) { i++; }

            while (i <= j && unsortedArray[j] >= unsortedArray[pivot]) { j--; }

            if (j < i) { done = true; } else {
                swap = unsortedArray[i];
                unsortedArray[i] = unsortedArray[j];
                unsortedArray[j] = swap;
            }
        }
        if (pivot != j) {
            swap = unsortedArray[pivot];
            unsortedArray[pivot] = unsortedArray[j];
            unsortedArray[j] = swap;
        }
        // System.Console.WriteLine("\n[Partition] ");
        // unsortedArray.ForEach(item => System.Console.Write(item.ToString() + " "));
        // System.Console.WriteLine("\nPivot: " + pivot);
        return j;
    }

    public static List<int> Sort (List<int> unsortedArray, int firstIndex, int lastIndex) {
        if (firstIndex < lastIndex) {
            var pivot = Partition (unsortedArray, firstIndex, lastIndex);
            QuickSort.Sort (unsortedArray, firstIndex, pivot - 1);
            QuickSort.Sort (unsortedArray, pivot + 1, unsortedArray.Count - 1);
        }
        return unsortedArray;
    }
}