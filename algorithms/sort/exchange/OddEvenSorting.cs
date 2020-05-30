namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class OddEvenSorting
  {
    bool notSortedYet = true;
    readonly int[] numbers;
    public OddEvenSorting(int[] numbers) => this.numbers = numbers;

    public void Sort()
    {
      var oddNumbers = new OddNumbers().GenerateUpTo(numbers.Length-1);
      var evenNumbers = new EvenNumbers().GenerateUpTo(numbers.Length-1);

      while(notSortedYet)
      {
        notSortedYet = false;

        foreach(var oddNumber in oddNumbers)
        {
          var leftNumber  = numbers[oddNumber];
          var rightNumber = numbers[oddNumber+1];

          if(leftNumber > rightNumber)
          {
            notSortedYet = true;
            numbers[oddNumber]   = numbers[oddNumber+1];
            numbers[oddNumber+1] = numbers[oddNumber];
          }
        }

        foreach(var evenNumber in evenNumbers)
        {
          var leftNumber = numbers[evenNumber];
          var rightNumber = numbers[evenNumber+1];

          if(leftNumber > rightNumber)
          {
            notSortedYet = true;
            numbers[evenNumber] = numbers[evenNumber+1];
            numbers[evenNumber+1] = numbers[evenNumber];
          }
        }
      }
    }
  }
}