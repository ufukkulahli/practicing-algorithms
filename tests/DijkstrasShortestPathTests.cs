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

    [Fact]
    public void ResetAllDistancesToInfinite_And_ResetVisitedVertices()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();

      // Act
      shortestPath.Reset();

      // Assert
      Assert.Equal(2147483647, shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[8]);

      Assert.False(shortestPath.visitedVertices[0]);
      Assert.False(shortestPath.visitedVertices[1]);
      Assert.False(shortestPath.visitedVertices[2]);
      Assert.False(shortestPath.visitedVertices[3]);
      Assert.False(shortestPath.visitedVertices[4]);
      Assert.False(shortestPath.visitedVertices[5]);
      Assert.False(shortestPath.visitedVertices[6]);
      Assert.False(shortestPath.visitedVertices[7]);
      Assert.False(shortestPath.visitedVertices[8]);
    }

    [Fact]
    public void ResetSourceVertexDistance()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();

      // Act
      shortestPath.Reset();
      shortestPath.ResetDistanceOfSourceVertex(5);

      // Assert
      Assert.Equal(2147483647, shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[4]);
      Assert.Equal(0         , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[8]);
    }

  }
}