using Xunit;
using practicing_algorithms.algorithms.sort.selection;
using practicing_algorithms.algorithms;

namespace practicing_algorithms.tests.sort.selection
{
  public class HeapSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var actualNumbers   = new int[5]{5, 4, 3, 2, 1};
      var expectedNumbers = new int[5]{1, 2, 3, 4, 5};

      // Act
      new HeapSorting(actualNumbers).Sort();

      // Assert
      Assert.Equal(expectedNumbers, actualNumbers);
    }

    [Fact]
    public void FindStartingIndexTest()
    {
      // Arrange
      var numbers = new int[6]{1,2,3,4,5,6};

      // Act
      var startingIndex = new HeapSorting(numbers).FindStartingIndex();

      // Assert
      Assert.Equal(2, startingIndex);
    }

    [Fact]
    public void RebuildHeapTest()
    {
      // Arrange
      var numbers = new int[3]{2, 4, 6};

      // Act
      new HeapSorting(numbers).RebuildHeap(numbers.Count(), 0);

      // Assert
      Assert.Equal(new int[3]{4, 2, 6}, numbers);
    }
  }
}
