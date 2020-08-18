namespace practicing_algorithms.algorithms.sort.distribution
{
  public sealed class RadixSorting
  {
    public void Sort()
    {
      throw new System.NotImplementedException();
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

    public void OccurenceOfNumbers(int[] numbers, int[] occurences, int place)
    {
      for(var index=0;  index<numbers.Count();  index++)
      {
        var result = (numbers[index]/place) % 10;
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
      int[] outputs = new int[occurences.Length];

      for(var index=occurences.Count();  index>=0;  index--)
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

  }
}
