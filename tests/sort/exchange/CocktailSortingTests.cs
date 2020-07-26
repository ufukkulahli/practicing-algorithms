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
  }
}