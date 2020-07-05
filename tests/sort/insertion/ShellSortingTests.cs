using Xunit;
using practicing_algorithms.algorithms.sort.insertion;

namespace practicing_algorithms.tests.sort.insertion
{
  public class ShellSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new ShellSorting( new int[3]{3,2,1} ).Sort() );
    }
  }
}
