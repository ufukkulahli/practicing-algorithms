namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class HeapSorting
  {
    readonly int[] unorderedNumbers;

    public HeapSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
    }

    public void Sort()
    {
      for(var index=FindStartingIndex(unorderedNumbers); index>=0; index--)
      {
        RebuildHeap(index);
      }

      for(var index=(unorderedNumbers.Count()); index>=0; index--)
      {
        var firstItem = unorderedNumbers[0];

        unorderedNumbers[0]     = unorderedNumbers[index];
        unorderedNumbers[index] = firstItem;

        RebuildHeap(0);
      }
    }

    int FindStartingIndex(int[] unorderedNumbers) => (unorderedNumbers.Length/2) - 1;

    void RebuildHeap(int i)
    {
        var largest = i;
        var left    = 2 * i + 1;
        var right   = 2 * i + 2;

        if (left < unorderedNumbers.Length && unorderedNumbers[left] > unorderedNumbers[largest])
        {
            largest = left;
        }
        if (right < unorderedNumbers.Length && unorderedNumbers[right] > unorderedNumbers[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            var numberToBeSwapped     = unorderedNumbers[i];
            unorderedNumbers[i]       = unorderedNumbers[largest];
            unorderedNumbers[largest] = numberToBeSwapped;

            RebuildHeap(largest);
        }
    }
  }
}
