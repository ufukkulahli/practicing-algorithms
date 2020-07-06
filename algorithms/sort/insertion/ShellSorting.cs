namespace practicing_algorithms.algorithms.sort.insertion
{
  public sealed class ShellSorting
  {
    readonly int[] unorderedNumbers;

    public ShellSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
    }

    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public void Sort(int[] array)
    {
      for (var gapSize=(array.Length/2);  gapSize>0;  gapSize/= 2)
      {
        for (var index=gapSize;  index<array.Length;  index+= 1)
        {
          var currentNumber = array[index];
          var j=0;

          for (j = index;  (j>=gapSize && array[j-gapSize] > currentNumber);  j-= gapSize)
          {
            array[j] = array[j-gapSize];
          }

          array[j] = currentNumber;
        }
      }
    }
  }
}
