namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class OddEvenSorting
  {
    bool notSortedYet = true;
    readonly int[] numbers;

    public OddEvenSorting(int[] numbers) => this.numbers = numbers;

    public void Sort()
    {
      while(notSortedYet)
      {
        notSortedYet = false;

        var oddIndexes = new OddNumbers().GenerateUpTo(numbers.Length-2);
        var oddIndexSorting = new SortedNumbers(numbers, oddIndexes);
        notSortedYet = oddIndexSorting.Sort();

        var evenIndexes = new EvenNumbers().GenerateUpTo(numbers.Length-2);
        var evenIndexSorting = new SortedNumbers(numbers, evenIndexes);
        notSortedYet = evenIndexSorting.Sort();
      }
    }
  }
}