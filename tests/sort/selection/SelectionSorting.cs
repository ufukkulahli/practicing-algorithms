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
  }
}
