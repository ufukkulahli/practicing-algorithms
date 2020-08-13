namespace practicing_algorithms.algorithms.sort.distribution
{
  public sealed class RadixSorting
  {
    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public int FindBiggest(int[] numbers)
    {
      var biggest = numbers[0];

      for (var index = 1; index < numbers.Length; index++)
      {
        if (numbers[index] > biggest)
        {
          biggest = numbers[index];
        }
      }

      return biggest;
    }
  }
}
