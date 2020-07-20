using Xunit;
using practicing_algorithms.algorithms.sort.distribution;

namespace practicing_algorithms.tests.sort.exchange
{
  public class CountingSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var actualNumbers = new int[5] { 5, 4, 3, 2, 1 };
      var expectedNumbers = new int[5] { 1, 2, 3, 4, 5 };

      // Act
      // TODO

      // Assert
      Assert.Throws<System.NotImplementedException>(() => new CountingSorting(actualNumbers).Sort());
    }

    [Fact]
    public void FindBiggestNumberTest()
    {
      // Arrange
      var numbers = new int[5] { 5, 4, 3, 2, 1 };

      // Act
      var biggestNumber = new CountingSorting(numbers).FindBiggestNumber();

      // Assert
      Assert.Equal(5, biggestNumber);
    }

    [Fact]
    public void InitializeCountArrayToZeroTest()
    {
      // Arrange
      var countArray = new int[5]{0,0,0,0,0};

      // Act
      var actual = new CountingSorting(new int[0]).InitializeCountArrayToZeros(5);

      // Assert
      Assert.Equal(countArray, actual);
    }

    [Fact]
    public void StoreCountOfEachNumberTest()
    {
      // Arrange
      var numbers = new int[5]{1,1,2,2,3};
      var biggestNumber = new CountingSorting(numbers).FindBiggestNumber();
      var countArray = new int[biggestNumber+1];

      // Act
      new CountingSorting(numbers).FindOccurenceOfEachNumber(countArray);

      // Assert
      Assert.Equal(new int[4]{0,2,2,1},  countArray);
    }

    [Fact]
    public void FindCumulativeCountOfEachOccurenceTest()
    {
      // Arrange
      var numbers = new int[5]{1,1,2,2,3};
      var biggestNumber = new CountingSorting(numbers).FindBiggestNumber();
      var occurences = new int[biggestNumber+1];
      new CountingSorting(numbers).FindOccurenceOfEachNumber(occurences);

      // Act
      new CountingSorting(new int[0]).FindCumulativeCountOfEachOccurence(occurences, biggestNumber);

      // Assert
      Assert.Equal(new int[4]{0,2,4,5}, occurences);
    }

    [Fact]
    public void BuildOutputTest()
    {
      var numbers = new int[5]{1,1,2,2,3};
      var biggestNumber = new CountingSorting(numbers).FindBiggestNumber();
      var occurences = new int[biggestNumber+1];
      var countingSorting = new CountingSorting(numbers);
      countingSorting.FindOccurenceOfEachNumber(occurences);

      // Act
      var actual = countingSorting.BuildOutput(occurences);

      // Assert
      Assert.Equal(new int[6]{1,0,2,0,0,0}, actual);
    }
  }
}

