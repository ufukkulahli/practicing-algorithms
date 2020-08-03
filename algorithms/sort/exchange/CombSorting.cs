namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class CombSorting
  {
    readonly int[] unorderedNumbers;
    int gapSize;
    bool completedSwappingNumbers;
    readonly Numbers numbers;

    public CombSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers          = unorderedNumbers;
      this.gapSize                   = unorderedNumbers.Length;
      this.completedSwappingNumbers  = true;
      this.numbers                   = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      while (NotSortedYet())
      {
        this.gapSize = FindGapSize();

        completedSwappingNumbers = false;

        IterateNumbersByGapSize();
      }
    }

    public void IterateNumbersByGapSize()
    {
      for (var index=0;  index<unorderedNumbers.Length-gapSize;  index++)
      {
        var leftNumber  = unorderedNumbers[index];
        var rightNumber = unorderedNumbers[index+gapSize];

        if(leftNumber > rightNumber)
        {
          numbers.SwapNumbersAtIndexes(index+gapSize, index);
          completedSwappingNumbers = true;
        }
      }
    }

    public bool NotSortedYet() => gapSize != 1  ||  completedSwappingNumbers == true;

    public int FindGapSize()
    {
      var newGapSize = (this.gapSize * 10) / 13;

      if (newGapSize < 1)
      {
        return 1;
      }

      return newGapSize;
    }
  }
}
