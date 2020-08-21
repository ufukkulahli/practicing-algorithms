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
      var biggestNumber = this.FindBiggestNumber();
      var occurences = new int[biggestNumber + 1];
      this.FindOccurenceOfEachNumber(occurences);
      this.FindCumulativeCountOfEachOccurence(occurences, biggestNumber);
      var output = this.BuildOutput(occurences);
      this.FinalizeSorting(output);
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

      for(var index=unorderedNumbers.ZeroIndexBasedCount();  index>=0;  index--)
      {
        var currentNumber                  = unorderedNumbers[index];
        var occurenceOfCurrentNumber       = occurences[currentNumber];
        output[occurenceOfCurrentNumber-1] = currentNumber;

        occurences[currentNumber]--;
      }

      return output;
    }

    public void FinalizeSorting(int[] output)
    {
      for(var index=0;  index<unorderedNumbers.Length;  index++)
      {
        unorderedNumbers[index] = output[index];
      }
    }
  }
}
