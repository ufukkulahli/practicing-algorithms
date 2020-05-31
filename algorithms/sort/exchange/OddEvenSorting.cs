namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class OddEvenSorting
  {
    bool notSortedYet = true;
    readonly int[] unorderedNumbers;

    public OddEvenSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      while(notSortedYet)
      {
        notSortedYet    = false;
        var numbers     = new Numbers(unorderedNumbers);

        var oddIndexes  = new OddNumbers().GenerateUpTo(unorderedNumbers.Length-2);
        notSortedYet    = numbers.SortByIndexes(oddIndexes);

        var evenIndexes = new EvenNumbers().GenerateUpTo(unorderedNumbers.Length-2);
        notSortedYet    = numbers.SortByIndexes(evenIndexes);
      }
    }
  }
}