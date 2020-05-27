using static System.Console;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class BubbleSorting
  {
    readonly int[] numbers;
    public BubbleSorting(int[] numbers) => this.numbers = numbers;

    public void Sort()
    {
      for(var outerIndex=0; outerIndex<=numbers.Length-2; outerIndex++)
      {
        for(var index=0; index<=numbers.Length-2; index++)
        {
          var numberAtLeft  = numbers[index];
          var numberAtRight = numbers[index+1];

          Print(outerIndex, index, numberAtLeft, numberAtRight);

          if(numberAtLeft > numberAtRight)
          {
            numbers[index+1] = numberAtLeft;
            numbers[index]   = numberAtRight;
            Print();
          }
        }
      }
    }

    void Print(int outerIndex, int index, int numberAtLeft, int numberAtRight)
    {
      Write("Curr:" + string.Join(',', numbers) + " ");
      Write(outerIndex + ":" + index + ":" + (index+1) + "=>");
      Write(numberAtLeft + "," + numberAtRight);
    }
    void Print() => WriteLine(" New:" + string.Join(',', numbers));
  }
}