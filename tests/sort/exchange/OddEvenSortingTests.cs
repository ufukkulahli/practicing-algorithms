using System;
using practicing_algorithms.algorithms.sort.exchange;
using Xunit;

namespace practicing_algorithms.tests.sort.exchange
{
  public sealed class OddEvenSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<NotImplementedException>( () => new OddEvenSorting(new int[0]).Sort() );
    }

    [Fact]
    public void EvenNumbersTest()
    {
      var expectedEvenNumber = 0;
      foreach(var evenNumber in new EvenNumbers().GenerateUpTo(10))
      {
        evenNumber.WriteLine();
        Assert.Equal(expectedEvenNumber, evenNumber);
        expectedEvenNumber += 2;
      }
    }

    [Fact]
    public void OddNumbersTest()
    {
      var expectedOddNumber = 1;
      foreach(var oddNumber in new OddNumbers().GenerateUpTo(10))
      {
        oddNumber.WriteLine();
        Assert.Equal(expectedOddNumber, oddNumber);
        expectedOddNumber += 2;
      }
    }
  }
}
