using System.Collections.Generic;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class Numbers
  {
    readonly int[] numbers;
    readonly IEnumerable<int> indexes;
    bool notSortedYet;

    public Numbers(int[] numbers) => this.numbers = numbers;

    public bool SortByIndexes(IEnumerable<int> indexes)
    {
      foreach(var index in indexes)
      {
        var currentLeftNumber  = numbers[index];
        var currentRightNumber = numbers[index+1];

        if(currentLeftNumber > currentRightNumber)
        {
          notSortedYet     = true;
          numbers[index]   = currentRightNumber;
          numbers[index+1] = currentLeftNumber;
        }
      }
      return notSortedYet;
    }
  }
}
