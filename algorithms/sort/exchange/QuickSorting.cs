namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class QuickSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;

    public QuickSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      Sort(0, unorderedNumbers.Count());
    }

    void Sort(int low, int high)
    {
      if(low >= high)
      {
        return;
      }

      var partitionIndex = Partition(low, high);

      Sort(low, partitionIndex-1);
      Sort(partitionIndex+1, high);
    }

    int Partition(int low, int high)
    {
      var pivot    = unorderedNumbers[high];
      var lowIndex = low-1;

      for(var index=low; index<high; index++)
      {
        var currentItem = unorderedNumbers[index];

        if(currentItem > pivot)
        {
          continue;
        }

        lowIndex++;

        numbers.SwapNumbersAtIndexes(lowIndex, index);
      }

      var nextLowIndex = lowIndex+1;

      numbers.SwapNumbersAtIndexes(nextLowIndex, high);

      return nextLowIndex;
    }
  }
}