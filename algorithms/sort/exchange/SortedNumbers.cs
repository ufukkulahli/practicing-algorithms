using System.Collections.Generic;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class SortedNumbers
  {
    readonly int[] numbers;
    readonly IEnumerable<int> indexes;
    bool notSortedYet;

    public SortedNumbers(int[] numbers, IEnumerable<int> indexes)
    {
      this.numbers = numbers;
      this.indexes = indexes;
    }

    public bool Sort()
    {
      foreach(var index in indexes)
      {
        var leftNumber  = numbers[index];
        var rightNumber = numbers[index+1];

        if(leftNumber > rightNumber)
        {
          notSortedYet = true;
          numbers[index]   = rightNumber;
          numbers[index+1] = leftNumber;
        }
      }
      return notSortedYet;
    }
  }
}
