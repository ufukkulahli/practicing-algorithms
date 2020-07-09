using Xunit;
using practicing_algorithms.algorithms.sort.exchange;

namespace practicing_algorithms.tests.sort.exchange
{
  public class CombSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new CombSorting( new int[3] {3,2,1} ).Sort() );
    }
  }
}
