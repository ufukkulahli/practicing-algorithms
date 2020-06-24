using System;

namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class SelectionSorting
  {
    readonly int[] unorderedNumbers;

    public SelectionSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort() => throw new NotImplementedException();

    int StartFrom(int index) => index+1;

    public int FindSmallestIndex(int indexToStartScanning)
    {
      var indexOfSmallestNumber = indexToStartScanning;

      for(var innerIndex=StartFrom(indexToStartScanning);  innerIndex<unorderedNumbers.Length;  innerIndex++)
      {
        var leftNumber  = unorderedNumbers[indexToStartScanning];
        var rightNumber = unorderedNumbers[innerIndex];

        if(rightNumber < leftNumber)
        {
          indexOfSmallestNumber = innerIndex;
        }
      }

      return indexOfSmallestNumber;
    }
  }
}
