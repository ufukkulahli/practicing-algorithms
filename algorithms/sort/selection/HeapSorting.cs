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
      for(var index=FindStartingIndex(); index>=0; index--)
      {
        RebuildHeap(unorderedNumbers.Length, index);
      }
    }

    public int FindStartingIndex() => (unorderedNumbers.Length/2) - 1;

    // TODO: Write test
    public void RebuildHeap(int sizeOfHeap, int indexOfNode)
    {
      var indexOfParentNode     = indexOfNode;
      var indexOfLeftChildNode  = 2 * indexOfNode + 1;
      var indexOfRightChildNode = 2 * indexOfNode + 2;

      if (indexOfLeftChildNode < sizeOfHeap && unorderedNumbers[indexOfLeftChildNode] > unorderedNumbers[indexOfParentNode])
      {
        indexOfParentNode = indexOfLeftChildNode;
      }
      if (indexOfRightChildNode < sizeOfHeap && unorderedNumbers[indexOfRightChildNode] > unorderedNumbers[indexOfParentNode])
      {
        indexOfParentNode = indexOfRightChildNode;
      }
      if (indexOfParentNode != indexOfNode)
      {
        numbers.SwapNumbersAtIndexes(indexOfNode, indexOfParentNode);
        RebuildHeap(sizeOfHeap, indexOfParentNode);
      }
    }
  }
}
