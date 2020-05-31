using static System.Console;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class BubbleSorting
  {
    readonly int[] unorderedNumbers;
    public BubbleSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      var numbers = new Numbers(unorderedNumbers);

      for(var outerIndex=0; outerIndex<=unorderedNumbers.Length-2; outerIndex++)
      {
        for(var index=0; index<=unorderedNumbers.Length-2; index++)
        {
          var numberAtLeft  = unorderedNumbers[index];
          var numberAtRight = unorderedNumbers[index+1];

          Print(outerIndex, index, numberAtLeft, numberAtRight);

          if(numberAtLeft > numberAtRight)
          {
            numbers.SwapNumberAndNextAt(index);
            Print();
          }
        }
      }
    }

    void Print(int outerIndex, int index, int numberAtLeft, int numberAtRight)
    {
      Write("Curr:" + string.Join(',', unorderedNumbers) + " ");
      Write(outerIndex + ":" + index + ":" + (index+1) + "=>");
      Write(numberAtLeft + "," + numberAtRight);
    }
    void Print() => WriteLine(" New:" + string.Join(',', unorderedNumbers));
  }
}