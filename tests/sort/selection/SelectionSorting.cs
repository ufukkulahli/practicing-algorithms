using Xunit;
using System;
using practicing_algorithms.algorithms.sort.selection;

namespace practicing_algorithms.tests.sort.selection
{
  public class SelectionSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var numbers       = new int[5]{5,4,3,2,1};
      var sortedNumbers = new int[5]{1,2,3,4,5};

      // Act && Assert
      Assert.Throws<NotImplementedException>( () => new SelectionSorting(numbers).Sort() );
      Assert.NotEqual(sortedNumbers, numbers);
    }

    public void FindSmallestIndexTest()
    {
      // Arrange
      var numbers       = new int[5]{5,4,3,2,1};

      // Act
      var indexIs_Zero_and_smallestNumberIs_1 = new SelectionSorting(numbers).FindSmallestIndex(0);
      var indexIs_One_and_smallestNumberIs_2 = new SelectionSorting(numbers).FindSmallestIndex(1);

      // Assert
      Assert.Equal(0, indexIs_Zero_and_smallestNumberIs_1);
      Assert.Equal(2, indexIs_One_and_smallestNumberIs_2);
    }
  }
}
