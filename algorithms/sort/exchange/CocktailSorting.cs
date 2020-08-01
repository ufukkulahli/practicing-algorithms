namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class CocktailSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;
    bool shouldContinueSorting = true;
    int end = 0;
    int start = 0;

    public CocktailSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers = new Numbers(unorderedNumbers);
      this.end = unorderedNumbers.Length;
    }

    public void Sort()
    {
      while(shouldContinueSorting)
      {
        shouldContinueSorting = false;
        IterateAndSwapNumbersIfNeed(start, end-1);
        if(shouldContinueSorting==false)
        {
          break;
        }
        shouldContinueSorting=true;
        end-=1;
        IterateReverseAndSwapNumbersIfNeed(end-1, start);
        start+=1;
      }
    }

    // TODO: DELETE PARAMETERS WHEN ITS TEST IS MADE COMPATIBLE
    public void IterateAndSwapNumbersIfNeed(int start, int end)
    {
      for(var index=start;  index<end;  index++)
      {
        var leftNumber=unorderedNumbers[index];
        var rightNumber=unorderedNumbers[index+1];

        if(leftNumber>rightNumber)
        {
          this.numbers.SwapNumberAndNextAt(index);
          shouldContinueSorting = true;
        }
      }
    }

    // TODO: DELETE PARAMETERS WHEN ITS TEST IS MADE COMPATIBLE
    public void IterateReverseAndSwapNumbersIfNeed(int start, int end)
    {
      for(var index=start;  index>=end;  index--)
      {
        var leftNumber = unorderedNumbers[index];
        var rightNumber = unorderedNumbers[index+1];

        if(leftNumber > rightNumber)
        {
          this.numbers.SwapNumberAndNextAt(index);
          shouldContinueSorting = true;
        }
      }
    }
  }
}