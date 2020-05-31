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
        var sn = new SortedNumbers(numbers);

        var oddIndexes = new OddNumbers().GenerateUpTo(numbers.Length-2);
        var oddIndexSorting = sn;
        notSortedYet = oddIndexSorting.ByIndexes(oddIndexes);

        var evenIndexes = new EvenNumbers().GenerateUpTo(numbers.Length-2);
        var evenIndexSorting = sn;
        notSortedYet = evenIndexSorting.ByIndexes(evenIndexes);
      }
    }
  }
}