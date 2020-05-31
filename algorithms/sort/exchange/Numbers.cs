using System.Collections.Generic;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class Numbers
  {
    readonly int[] numbers;
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
          SwapNumberAndNextAt(index);
        }
      }
      return notSortedYet;
    }

    public void SwapNumberAndNextAt(int index)
    {
      var leftNumber   = numbers[index];
      var rightNumber  = numbers[index+1];

      numbers[index]   = rightNumber;
      numbers[index+1] = leftNumber;
    }
  }
}
