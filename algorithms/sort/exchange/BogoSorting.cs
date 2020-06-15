using System;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class BogoSorting
  {
    readonly int[] unorderedNumbers;

    public BogoSorting(int[] numbers) => unorderedNumbers = numbers;

    public void Sort() => throw new NotImplementedException();

    public bool IsSorted() => new Numbers(unorderedNumbers).IsSorted();
  }
}
