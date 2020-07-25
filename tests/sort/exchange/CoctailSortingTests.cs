using Xunit;
using practicing_algorithms.algorithms.sort.exchange;

namespace practicing_algorithms.tests.sort.exchange
{
  public class CoctailSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new CoctailSorting(new int[0]).Sort() );
    }
  }
}