using System;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class BogoSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;
    readonly Random random = new Random();
    int trialTime;

    public BogoSorting(int[] numbers)
    {
      this.unorderedNumbers = numbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      while(IsNotSorted())
      {
        Shuffle();
        CollectTrialTime();
      }
    }

    public bool IsSorted() => numbers.IsSorted();

    public bool IsNotSorted() => ! IsSorted();

    public void Swap(int index, int nextIndex) => numbers.SwapNumbersAtIndexes(index, nextIndex);

    public int GetRandomIndexOfArray() => random.Next(unorderedNumbers.Count());

    public void Shuffle()
    {
      for(var index=0; index<=unorderedNumbers.Count(); index++)
      {
        Swap(GetRandomIndexOfArray(), index);
      }
    }

    public int TrialTime() => trialTime;

    void CollectTrialTime() => trialTime++;
  }
}
