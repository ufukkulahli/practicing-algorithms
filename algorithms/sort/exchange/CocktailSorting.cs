namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class CocktailSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;

    public CocktailSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public void IterateAndSwapNumbersIfNeed()
    {
      for(var index=0;  index<unorderedNumbers.Count();  index++)
      {
        var leftNumber=unorderedNumbers[index];
        var rightNumber=unorderedNumbers[index+1];

        if(leftNumber>rightNumber)
        {
          this.numbers.SwapNumberAndNextAt(index);
        }
      }
    }

    public void IterateReverseAndSwapNumbersIfNeed(int start, int end)
    {
      for(var index=start;  index>=end;  index++)
      {
        var leftNumber = unorderedNumbers[index];
        var rightNumber = unorderedNumbers[index+1];

        if(leftNumber > rightNumber)
        {
          this.numbers.SwapNumberAndNextAt(index);
        }
      }
    }
  }
}