using System;

namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class HeapSorting
  {
    public void Sort() => throw new NotImplementedException();

    void Sort(int[] array)
    {
      for(var index=FindStartingIndex(array); index>=0; index--)
      {
        RebuildHeap(array, array.Length, index);
      }

      for(var index=(array.Length-1); index>=0; index--)
      {
        var firstItem = array[0];

        array[0]     = array[index];
        array[index] = firstItem;

        RebuildHeap(array, index, 0);
      }
    }

    int FindStartingIndex(int[] array) => (array.Length/2) - 1;

    void RebuildHeap(int[] array, int length, int i)
    {
        var largest = i;
        var left    = 2 * i + 1;
        var right   = 2 * i + 2;

        if (left < length && array[left] > array[largest])
        {
            largest = left;
        }
        if (right < length && array[right] > array[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            var swap       = array[i];
            array[i]       = array[largest];
            array[largest] = swap;

            RebuildHeap(array, length, largest);
        }
    }
  }
}
