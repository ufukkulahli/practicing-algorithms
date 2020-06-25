using System;

namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class SelectionSorting
  {
    readonly int[] unorderedNumbers;

    public SelectionSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort() => throw new NotImplementedException();

    public int FindIndexOfSmallestNumberStartingFrom(int startingIndex)
    {
      var indexOfSmallestNumber = startingIndex;

      for(var index=startingIndex;  index<unorderedNumbers.Length;  index++)
      {
        var currentNumber      = unorderedNumbers[index];
        var lastSmallestNumber = unorderedNumbers[indexOfSmallestNumber];

        if(currentNumber < lastSmallestNumber)
        {
          indexOfSmallestNumber = index;
        }
      }

      return indexOfSmallestNumber;
    }
  }
}
