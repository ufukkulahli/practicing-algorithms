using Xunit;
using practicing_algorithms.algorithms.sort.exchange;

namespace practicing_algorithms.tests.sort.exchange
{
  public class CocktailSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new CocktailSorting(new int[0]).Sort() );
    }

    [Fact]
    public void IterateNumbersTest()
    {
      // Arrange
      var unorderedNumbers = new int[5]{5,4,3,2,1};
      var expectedNumbers = new int[5]{4,3,2,1,5};

      // Act
      new CocktailSorting(unorderedNumbers).IterateAndSwapNumbersIfNeed();

      // Assert
      Assert.Equal(expectedNumbers, unorderedNumbers);
    }
  }
}