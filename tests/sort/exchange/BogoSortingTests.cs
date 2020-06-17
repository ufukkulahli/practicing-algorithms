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

    [Fact]
    public void SwapNumbersAtGivenIndexes()
    {
      var swappedNumbers = new int[3]{1,2,3};
      var bogoSorting = new BogoSorting(swappedNumbers);

      // Act
      bogoSorting.Swap(0,1);
      // Assert
      Assert.Equal(new int[3]{2,1,3}, swappedNumbers);

      // Act
      bogoSorting.Swap(1,2);
      // Assert
      Assert.Equal(new int[3]{2,3,1}, swappedNumbers);
    }

    [Fact]
    public void RandomIndexFromNumbers()
    {
      // Arrange
      var actualNumbers = new int[5]{5,4,3,2,1};

      // Act
      var randomIndex = new BogoSorting(actualNumbers).GetRandomIndexFromNumbers();

      // Assert
      // TODO
    }

    [Fact]
    public void ShuffleNumbers()
    {
      // Arrange
      var actualNumbers = new int[5]{5,4,3,2,1};
      var original      = new int[5]{5,4,3,2,1};

      // Act
      new BogoSorting(actualNumbers).Shuffle();

      // Assert
      Assert.NotEqual(original, actualNumbers);
    }
  }
}
