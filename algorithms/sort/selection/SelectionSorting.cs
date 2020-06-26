namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class SelectionSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;

    public SelectionSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      for(var index=0;  index<unorderedNumbers.Count();  index++)
      {
        var indexOfSmallestNumber = FindIndexOfSmallestNumberStartingFrom(index);
        numbers.SwapNumbersAtIndexes(indexOfSmallestNumber, index);
      }
    }

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
