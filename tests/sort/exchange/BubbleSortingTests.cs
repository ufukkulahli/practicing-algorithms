using System;
using practicing_algorithms.algorithms.sort.exchange;
using Xunit;

namespace practicing_algorithms.tests.sort.exchange
{
  public sealed class BubbleSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var numbers = new int[3] {5,4,3};

      // Act
      new BubbleSorting(numbers).Sort();

      // Assert
      Assert.Equal(new int[3]{3,4,5}, numbers);
    }
  }
}
