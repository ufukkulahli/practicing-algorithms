namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class OddEvenSorting
  {
    bool notSortedYet = true;
    readonly int[] numbers;

    public OddEvenSorting(int[] numbers) => this.numbers = numbers;

    public void Sort()
    {
      while(notSortedYet)
      {
        notSortedYet = false;

        var oddNumbers = new OddNumbers().GenerateUpTo(numbers.Length-2);

        foreach(var oddNumber in oddNumbers)
        {
          var leftNumber  = numbers[oddNumber];
          var rightNumber = numbers[oddNumber+1];

          if(leftNumber > rightNumber)
          {
            notSortedYet = true;
            numbers[oddNumber]   = rightNumber;
            numbers[oddNumber+1] = leftNumber;
          }
        }

        var evenNumbers = new EvenNumbers().GenerateUpTo(numbers.Length-2);

        foreach(var evenNumber in evenNumbers)
        {
          var leftNumber = numbers[evenNumber];
          var rightNumber = numbers[evenNumber+1];

          if(leftNumber > rightNumber)
          {
            notSortedYet = true;
            numbers[evenNumber] = rightNumber;
            numbers[evenNumber+1] = leftNumber;
          }
        }
      }
    }
  }
}