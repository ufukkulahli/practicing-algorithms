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

      // Act
      var cocktailSorting = new CocktailSorting(unorderedNumbers);

      // ASSERT

      // First pass
      cocktailSorting.IterateAndSwapNumbersIfNeed();
      Assert.Equal(new int[5] { 4, 3, 2, 1, 5 }, unorderedNumbers);

      // Second pass
      cocktailSorting.IterateAndSwapNumbersIfNeed();
      Assert.Equal(new int[5]{3,2,1,4,5}, unorderedNumbers);

      // Third pass
      cocktailSorting.IterateAndSwapNumbersIfNeed();
      Assert.Equal(new int[5]{2,1,3,4,5}, unorderedNumbers);

      // Fourth pass
      cocktailSorting.IterateAndSwapNumbersIfNeed();
      Assert.Equal(new int[5]{1,2,3,4,5}, unorderedNumbers);
    }

    [Fact]
    public void IterateNumbersReversedTest()
    {
      // Arrange
      var unorderedNumbers = new int[5]{5,4,3,2,1};

      // Act
      var cocktailSorting = new CocktailSorting(unorderedNumbers);

      // ASSERT

      // First pass
      cocktailSorting.IterateReverseAndSwapNumbersIfNeed(3,0);
      Assert.Equal(new int[5] {1, 5, 4, 3, 2}, unorderedNumbers);

      // Second pass
      cocktailSorting.IterateReverseAndSwapNumbersIfNeed(3,0);
      Assert.Equal(new int[5] {1, 2, 5, 4, 3}, unorderedNumbers);

      // Third pass
      cocktailSorting.IterateReverseAndSwapNumbersIfNeed(3,0);
      Assert.Equal(new int[5] {1, 2, 3, 5, 4}, unorderedNumbers);

      // Fourth pass
      cocktailSorting.IterateReverseAndSwapNumbersIfNeed(3,0);
      Assert.Equal(new int[5] {1, 2, 3, 4, 5}, unorderedNumbers);
    }
  }
}