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

    public int[] InitializeCountArrayToZeros(int length)
    {
      var countArray = new int[length];

      for(var index=0; index<length; ++index)
      {
        countArray[index]=0;
      }

      return countArray;
    }

    public void FindOccurenceOfEachNumber(int[] countArray)
    {
      for(var index=0; index<unorderedNumbers.Length; index++)
      {
        var currentNumber = unorderedNumbers[index];
        countArray[currentNumber]++;
      }

    }

    public void FindCumulativeCountOfEachOccurence(int[] countArray, int biggestNumber)
    {
      for(var index=1; index<=biggestNumber; index++)
      {
        countArray[index] += countArray[index-1];
      }
    }

    public int[] BuildOutput(int[] occurences)
    {
      var output = new int[unorderedNumbers.Length+1];

      for(var index=unorderedNumbers.Count();  index>=0;  index--)
      {
        var currentNumber  = unorderedNumbers[index];
        var occurence      = occurences[currentNumber - 1];
        output[occurence]  = currentNumber;

        occurences[currentNumber]--;
      }

      return output;
    }
  }
}
