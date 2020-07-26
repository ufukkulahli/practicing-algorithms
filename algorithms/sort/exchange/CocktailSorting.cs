namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class CocktailSorting
  {
    readonly int[] unorderedNumbers;

    public CocktailSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public void IterateNumbers()
    {
      for(var index=0;  index<unorderedNumbers.Count();  index++)
      {
        var leftNumber=unorderedNumbers[index];
        var rightNumber=unorderedNumbers[index+1];

        if(leftNumber>rightNumber)
        {
          // TODO: SWAP NUMBERS
        }
      }
    }
  }
}