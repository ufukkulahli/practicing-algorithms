namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class CombSorting
  {
    readonly int[] unorderedNumbers;
    int gapSize;
    bool swappedNumbers;

    public CombSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.gapSize          = unorderedNumbers.Length;
      this.swappedNumbers   = true;
    }

    public void Sort()
    {
      while (gapSize != 1  ||  swappedNumbers == true)
      {
        gapSize = FindGapSize(gapSize);

        swappedNumbers = false;

        for (var index=0;  index<unorderedNumbers.Length-gapSize;  index++)
        {
          var leftNumber = unorderedNumbers[index];
          var rightNumber= unorderedNumbers[index+gapSize];

          if(leftNumber > rightNumber)
          {
            unorderedNumbers[index] = rightNumber;
            unorderedNumbers[index+gapSize] = leftNumber;

            swappedNumbers = true;
          }
        }
      }
    }

    public int FindGapSize(int currentGapSize)
    {
      var newGapSize = (currentGapSize * 10) / 13;

      if (newGapSize < 1)
      {
        return 1;
      }

      return newGapSize;
    }
  }
}
