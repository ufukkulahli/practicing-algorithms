using practicing_algorithms.algorithms.sort.exchange;
using Xunit;
using System;

namespace practicing_algorithms.tests.sort.exchange
{
  public class BogoSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var actualNumbers = new int[5]{5,4,3,2,1};

      // Act && Assert
      Assert.Throws<NotImplementedException>( () => new BogoSorting(actualNumbers).Sort() );
    }

    [Fact]
    public void NumbersAreNotSorted()
    {
      // Arrange && Act && Assert
      Assert.False(new BogoSorting(new int[5] { 5, 4, 3, 2, 1 }).IsSorted());
    }

    [Fact]
    public void NumbersAreSorted()
    {
      // Arrange && Act && Assert
      Assert.True(new BogoSorting(new int[5] {1,2,3,4,5}).IsSorted());
    }
  }
}
