using Xunit;
using practicing_algorithms.algorithms.sort.exchange;

namespace practicing_algorithms.tests.sort.exchange
{
  public class GnomeSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new GnomeSorting(new int[3]{3,2,1}).Sort() );
    }
  }
}
