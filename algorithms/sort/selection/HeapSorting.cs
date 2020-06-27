namespace practicing_algorithms.algorithms.sort.selection
{
  public sealed class HeapSorting
  {
    readonly int[] unorderedNumbers;
    readonly Numbers numbers;

    public HeapSorting(int[] unorderedNumbers)
    {
      this.unorderedNumbers = unorderedNumbers;
      this.numbers          = new Numbers(unorderedNumbers);
    }

    public void Sort()
    {
      RearrangeGivenArray();

      for(var index=(unorderedNumbers.Count()); index>=0; index--)
      {
        numbers.SwapNumbersAtIndexes(0, index);
        RebuildHeap(index, 0);
      }
    }

    public void RearrangeGivenArray()
    {
      for(var index=FindStartingIndex(unorderedNumbers); index>=0; index--)
      {
        RebuildHeap(unorderedNumbers.Length, index);
      }
    }

    int FindStartingIndex(int[] unorderedNumbers) => (unorderedNumbers.Length/2) - 1;

    void RebuildHeap(int length, int i)
    {
      var largest = i;
      var left    = 2 * i + 1;
      var right   = 2 * i + 2;

      if (left < length && unorderedNumbers[left] > unorderedNumbers[largest])
      {
        largest = left;
      }
      if (right < length && unorderedNumbers[right] > unorderedNumbers[largest])
      {
        largest = right;
      }
      if (largest != i)
      {
        numbers.SwapNumbersAtIndexes(i, largest);
        RebuildHeap(length, largest);
      }
    }
  }
}
