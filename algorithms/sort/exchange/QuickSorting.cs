using System;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class QuickSorting
  {
    readonly int[] unorderedNumbers;

    public QuickSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      Sort(unorderedNumbers, 0, unorderedNumbers.Length-1);
    }

    void Sort(int[] numbers, int low, int high)
    {
      if(low >= high)
      {
        return;
      }

      var partitionIndex = Partition(numbers, low, high);

      Sort(numbers, low, partitionIndex-1);
      Sort(numbers, partitionIndex+1, high);
    }

    int Partition(int[] array, int low, int high)
    {
      var pivot    = array[high];
      var lowIndex = low-1;

      for(var index=low; index<high; index++)
      {
        var currentItem = array[index];

        if(currentItem > pivot)
        {
          continue;
        }

        lowIndex++;
        var currentItemAtLowIndex = array[lowIndex];
        array[lowIndex]           = array[index];
        array[index]              = currentItemAtLowIndex;
      }

      var nextLowIndex       = lowIndex+1;
      var nextItemAtLowIndex = array[nextLowIndex];
      array[nextLowIndex]    = array[high];
      array[high]            = nextItemAtLowIndex;

      return nextLowIndex;
    }
  }
}