using System;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class QuickSorting
  {
    bool notSortedYet = true;
    readonly int[] unorderedNumbers;

    public QuickSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      throw new NotImplementedException();
    }

    void Sort(int[] numbers, int low, int high)
    {
      if(low > high)
      {
        return;
      }

      // TODO: Implement
      // var partitionIndex = Partition(numbers, low, high);
      var partitionIndex = 0;

      Sort(numbers, low, partitionIndex-1);
      Sort(numbers, partitionIndex-1, high);
    }
  }
}