using System;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class BogoSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;
    readonly Random random = new Random();

    public BogoSorting(int[] numbers)
    {
      this.unorderedNumbers = numbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort() => throw new NotImplementedException();

    public bool IsSorted() => numbers.IsSorted();

    public void Swap(int index, int nextIndex) => numbers.SwapNumbersAtIndexes(index, nextIndex);

    public int GetRandomIndexFromNumbers() => random.Next(unorderedNumbers.Length - 1);

    public void Shuffle()
    {
      for(var index=0; index<=unorderedNumbers.Length-1; index++)
      {
        Swap(GetRandomIndexFromNumbers(), index);
      }
    }
  }
}
