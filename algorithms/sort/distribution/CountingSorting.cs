namespace practicing_algorithms.algorithms.sort.distribution
{
  public sealed class CountingSorting
  {
    readonly int[] unorderedNumbers;

    public CountingSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
    }

    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public int FindBiggestNumber()
    {
      var biggestNumber = unorderedNumbers[0];

      for (var index=1;  index<unorderedNumbers.Length;  index++)
      {
        var currentNumer = unorderedNumbers[index];

        if(currentNumer > biggestNumber)
        {
          biggestNumber = currentNumer;
        }
      }

      return biggestNumber;
    }
  }
}
