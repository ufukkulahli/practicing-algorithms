namespace practicing_algorithms.algorithms.sort.insertion
{
  public sealed class InsertionSorting
  {
    readonly int[] unorderedNumbers;

    public InsertionSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
    }

    public void Sort()
    {
      for(var index=1;  index<unorderedNumbers.Length;  ++index)
      {
        var indexOfLeftNumber = index-1;

        var rightNumber = unorderedNumbers[index];
        var leftNumber  = unorderedNumbers[indexOfLeftNumber];

        while (indexOfLeftNumber >=0  &&  (leftNumber > rightNumber))
        {
          UpdateNumberAtIndex(indexOfLeftNumber+1 , indexOfLeftNumber);
          indexOfLeftNumber = indexOfLeftNumber-1;
        }

        unorderedNumbers[indexOfLeftNumber+1] = rightNumber;
      }
    }

    public void UpdateNumberAtIndex(int index, int nextIndex)
    {
      unorderedNumbers[index] = unorderedNumbers[nextIndex];
    }
  }
}
