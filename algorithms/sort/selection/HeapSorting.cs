using System;

namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class HeapSorting
  {
    public void Sort() => throw new NotImplementedException();
    
    void Heapify(int[] array, int length, int i)
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
          
            Heapify(array, length, largest);
        }
    }
  }
}
