namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class GnomeSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;
    int gnomesPosition;

    public GnomeSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      while (GnomeCouldStillAdvance())
      {
        if(GnomeIsAtTheStartPosition())
        {
          AdvanceGnomesPosition();
          continue;
        }

        var leftNumber  = unorderedNumbers[gnomesPosition-1];
        var rightNumber = unorderedNumbers[gnomesPosition];

        if(rightNumber >= leftNumber)
        {
          AdvanceGnomesPosition();
          continue;
        }

        numbers.SwapNumbersAtIndexes(gnomesPosition, gnomesPosition-1);
        DeclineGnomesPosition();
      }
    }

    public bool GnomeCouldStillAdvance()    => gnomesPosition < unorderedNumbers.Length;
    public bool GnomeIsAtTheStartPosition() => gnomesPosition == 0;
    public void AdvanceGnomesPosition()     => gnomesPosition ++;
    public void DeclineGnomesPosition()     => gnomesPosition --;
  }
}
