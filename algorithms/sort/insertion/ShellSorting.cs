namespace practicing_algorithms.algorithms.sort.insertion
{
  public sealed class ShellSorting
  {
    readonly int[] unorderedNumbers;

    public ShellSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
    }

    public void Sort()
    {
      for (var gapSize=(unorderedNumbers.Length/2);  gapSize>0;  gapSize/= 2)
      {
        for (var index=gapSize;  index<unorderedNumbers.Length;  index+= 1)
        {
          var currentNumber = unorderedNumbers[index];
          var j=0;

          for (j = index;  (j>=gapSize && unorderedNumbers[j-gapSize] > currentNumber);  j-= gapSize)
          {
            unorderedNumbers[j] = unorderedNumbers[j-gapSize];
          }

          unorderedNumbers[j] = currentNumber;
        }
      }
    }
  }
}
