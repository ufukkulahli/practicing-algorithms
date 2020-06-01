using System;
using practicing_algorithms.algorithms.sort.exchange;
using Xunit;

namespace practicing_algorithms.tests.sort.exchange
{
  public sealed class OddEvenSortingTests
  {
    [Fact]
    public void SortNumbers()
    {
      // Arrange
      var expectedNumbers = new int[5] {1,2,3,4,5};
      var actualNumbers   = new int[5] {5,4,3,2,1};

      // Act
      new OddEvenSorting(actualNumbers).Sort();

      // Assert
      Assert.Equal(expectedNumbers, actualNumbers);
    }

    [Fact]
    public void EvenNumbersTest()
    {
      var expectedEvenNumber = 0;
      foreach(var evenNumber in new OddEvenNumbers(NumberGeneration.Even).GenerateUpTo(10))
      {
        Assert.Equal(expectedEvenNumber, evenNumber);
        expectedEvenNumber += 2;
      }
    }

    [Fact]
    public void OddNumbersTest()
    {
      var expectedOddNumber = 1;
      foreach(var oddNumber in new OddEvenNumbers(NumberGeneration.Odd).GenerateUpTo(10))
      {
        Assert.Equal(expectedOddNumber, oddNumber);
        expectedOddNumber += 2;
      }
    }
  }
}
