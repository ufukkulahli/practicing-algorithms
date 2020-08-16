using practicing_algorithms.algorithms.sort.distribution;
using Xunit;

namespace practicing_algorithms.tests.sort.distribution
{
  public class RadixSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>(() => new RadixSorting().Sort());
    }

    [Fact]
    public void FindBiggestTest()
    {
      Assert.Equal(4, new RadixSorting().FindBiggest(new int[] { 1, 2, 3, 4 }));
    }

    [Fact]
    public void OccurenceTest()
    {
      // Arrange
      var numbers = new int[]{1,2,3,4};
      var occurences = new int[4];

      // Act
      new RadixSorting().OccurenceOfNumbers(numbers, occurences, 1);

      // Assert
      Assert.Equal(new int[4]{0,1,1,1}, occurences);
    }

    [Fact]
    public void CumulativeCountTest()
    {
      // Arrange
      var occurences = new int[4]{0,1,1,1};

      // Act
      new RadixSorting().CumulativeCount(occurences);

      // Assert
      Assert.Equal(new int[4]{0,1,2,3}, occurences);
    }

  }
}