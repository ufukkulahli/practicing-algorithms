namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class QuickSorting
  {
    readonly int[] unorderedNumbers;

    public QuickSorting(int[] unorderedNumbers) => this.unorderedNumbers = unorderedNumbers;

    public void Sort()
    {
      Sort(0, unorderedNumbers.Length-1);
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

        var currentItemAtLowIndex  = unorderedNumbers[lowIndex];
        unorderedNumbers[lowIndex] = unorderedNumbers[index];
        unorderedNumbers[index]    = currentItemAtLowIndex;
      }

      var nextLowIndex               = lowIndex+1;
      var nextItemAtLowIndex         = unorderedNumbers[nextLowIndex];
      unorderedNumbers[nextLowIndex] = unorderedNumbers[high];
      unorderedNumbers[high]         = nextItemAtLowIndex;

      return nextLowIndex;
    }
  }
}