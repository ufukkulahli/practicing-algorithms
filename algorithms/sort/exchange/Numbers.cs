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
