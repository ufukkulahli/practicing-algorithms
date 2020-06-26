using Xunit;
using practicing_algorithms.algorithms.sort.selection;

namespace practicing_algorithms.tests.sort.selection
{
  public class SelectionSortingTests
  {
    [Fact]
    public void SortingTest()
    {
      // Arrange
      var numbers       = new int[5]{5,4,3,2,1};
      var sortedNumbers = new int[5]{1,2,3,4,5};

      // Act && Assert
      new SelectionSorting(numbers).Sort();
      Assert.Equal(sortedNumbers, numbers);
    }

    [Fact]
    public void FindIndexOfSmallestNumberTest()
    {
      // Arrange
      var numbers = new int[5]{5,4,0,2,1};

      // Act
      var selectionSorting                       = new SelectionSorting(numbers);
      var smallestNumberIsZeroAndIndexIsTwo      = selectionSorting.FindIndexOfSmallestNumberStartingFrom(0);
      var smallestNumberIsStillZeroAndIndexIsTwo = selectionSorting.FindIndexOfSmallestNumberStartingFrom(1);
      var smallestNumberIsOneAndIndexIsFour      = selectionSorting.FindIndexOfSmallestNumberStartingFrom(3);

      // Assert
      Assert.Equal(2, smallestNumberIsZeroAndIndexIsTwo);
      Assert.Equal(2, smallestNumberIsStillZeroAndIndexIsTwo);
      Assert.Equal(4, smallestNumberIsOneAndIndexIsFour);
    }
  }
}
