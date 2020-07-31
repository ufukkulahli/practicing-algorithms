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
        IterateAndSwapNumbersIfNeed();
        if(shouldContinueSorting==false)
        {
          break;
        }
        shouldContinueSorting=true;
        end-=1;
        IterateReverseAndSwapNumbersIfNeed(end, start);
        start+=1;
      }
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
          shouldContinueSorting = true;
        }
      }
    }

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