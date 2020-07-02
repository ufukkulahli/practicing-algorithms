using Xunit;
using practicing_algorithms.algorithms.sort.insertion;

namespace practicing_algorithms.tests.sort.insertion
{
  public class InsertionSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new InsertionSorting( new int[3] {3,2,1} ).Sort() );
    }
  }
}
