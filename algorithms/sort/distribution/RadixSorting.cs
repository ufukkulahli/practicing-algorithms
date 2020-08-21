namespace practicing_algorithms.algorithms.sort.distribution
{
  public sealed class RadixSorting
  {

    public void Sort(int[] numbers)
    {
      var biggestNumber = FindBiggest(numbers);

      for(var place=1;  (biggestNumber/place)>0;  place*=10)
      {
        var biggest = FindBiggest(numbers);
        var occurences = BuildOccurences(biggest);
        OccurenceOfNumbers(numbers, occurences, place);
        CumulativeCount(occurences);
        var outputs = BuildOutput(numbers, occurences, place);
        CopyOutput(numbers, outputs);
      }

    }

    public int FindBiggest(int[] numbers)
    {
      var biggest = numbers[0];

      for (var index = 1; index < numbers.Length; index++)
      {
        if (numbers[index] > biggest)
        {
          biggest = numbers[index];
        }
      }

      return biggest;
    }

    public int[] BuildOccurences(int biggestNumber)
    {
      var occurences = new int[biggestNumber+1];

      for(var index=0;  index<biggestNumber;  index++)
      {
        occurences[index]=0;
      }

      return occurences;
    }

    public void OccurenceOfNumbers(int[] numbers, int[] occurences, int place)
    {
      for(var index=0;  index<numbers.Length;  index++)
      {
        int x = numbers[index] / place;
        var result = x % 10;
        occurences[result]++;
      }
    }

    public void CumulativeCount(int[] occurences)
    {
      for(var index=1;  index<occurences.Length;  index++)
      {
        occurences[index] += occurences[index-1];
      }
    }

    public int[] BuildOutput(int[] numbers, int[] occurences, int place)
    {
      int[] outputs = new int[numbers.Length+1];

      for(var index=numbers.ZeroIndexBasedCount();  index>=0;  index--)
      {
        var currentNumber  = numbers[index];
        var x              = currentNumber / place;
        var y              = x % 10;
        var number         = occurences[y];
        var current        = number - 1;

        outputs[current] = currentNumber;
        occurences[y]--;
      }

      return outputs;
    }

    public void CopyOutput(int[] numbers, int[] outputs)
    {
      for(var index=0;  index<numbers.Length;  index++)
      {
        numbers[index] = outputs[index];
      }
    }

  }
}
