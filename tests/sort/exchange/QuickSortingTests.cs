using System;
using practicing_algorithms.algorithms.sort.exchange;
using Xunit;

namespace practicing_algorithms.tests.sort.exchange
{
  public sealed class QuickSortingTests
  {
    [Fact]
    public void SortNumbers()
    {
      // Arrange
      var expectedNumbers = new int[5] {1,2,3,4,5};
      var actualNumbers   = new int[5] {5,4,3,2,1};

      // Act && Assert
      Assert.Throws<NotImplementedException>( () => new QuickSorting(actualNumbers).Sort() );
    }
  }
}
