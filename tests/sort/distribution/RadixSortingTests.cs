using practicing_algorithms.algorithms.sort.distribution;
using Xunit;

namespace practicing_algorithms.tests.sort.distribution
{
  public class RadixSortingTests
  {

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

    [Fact]
    public void BuildOutputTest()
    {
      // Arrange
      var occurences = new int[4]{0,1,1,1};
      var numbers = new int[]{4,3,2,1};
      new RadixSorting().CumulativeCount(occurences);

      // Act
      var output = new RadixSorting().BuildOutput(numbers, occurences, 1);

      // Assert
      Assert.NotEqual(new int[4]{1,2,3,4}, output);
    }

    [Fact]
    public void CopyOutputTest()
    {
      // Arrange
      var outputs = new int[4]{1,2,3,4};
      var numbers = new int[]{4,3,2,1};

      // Act
      new RadixSorting().CopyOutput(numbers, outputs);

      // Assert
      Assert.Equal(new int[4]{1,2,3,4}, numbers);
    }

    [Fact]
    public void SortingTest()
    {
      // Arrange
      var numbers = new int[]{4,3,2,1};

      // Act
      new RadixSorting().Sort(numbers);

      // Assert
      Assert.NotEqual(new int[4]{1,2,3,4}, numbers);
    }

  }
}