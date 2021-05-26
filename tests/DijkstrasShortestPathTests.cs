using practicing_algorithms.algorithms;
using Xunit;

namespace practicing_algorithms.tests
{
  public class DijkstrasShortestPathTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new DijkstrasShortestPath().Find(null, 0) );
    }
  }
}