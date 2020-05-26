using static System.Console;

namespace practicing_algorithms.algorithms.sort
{
  public sealed class BubbleSorting
  {
    readonly int[] numbers;
    public BubbleSorting(int[] numbers) => this.numbers = numbers;

    public void Sort()
    {
      for(var i=0; i<=numbers.Length-2; i++)
      {
        for(var index=0; index<=numbers.Length-2; index++)
        {
          var numberAtLeft  = numbers[index];
          var numberAtRight = numbers[index+1];

          Print(i, index, numberAtLeft, numberAtRight);

          if(numberAtLeft > numberAtRight)
          {
            numbers[index+1] = numberAtLeft;
            numbers[index]   = numberAtRight;
            Print();
          }
        }
      }
    }

    void Print(int i, int index, int numberAtLeft, int numberAtRight)
    {
      Write("Curr:" + string.Join(',', numbers) + " ");
      Write(i + ":" + index + ":" + (index+1) + "=>");
      Write(numberAtLeft + "," + numberAtRight);
    }
    void Print() => WriteLine(" New:" + string.Join(',', numbers));
  }
}
