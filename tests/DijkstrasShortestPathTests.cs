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

      Assert.False(shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[6]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[7]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[8]);
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

    [Fact]
    public void UpdateShortestPath()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();
      shortestPath.Reset();

      var graph = new int[,]
      {
        { 0, 0, 0 },
        { 3, 1, 0 },
        { 0, 7, 0 }
      };

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

      // Manipulate data for testing purposes.
      // These values will be set in the loop
      shortestPath.ResetDistanceOfSourceVertex(sourceVertexIndex: index_u);
      shortestPath.SetShortestDistance(index_u, value: 2);
      shortestPath.SetShortestDistance(index_v, value: 9);

      // Pre-act 2
      Assert.Equal(9          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

      // Act
      shortestPath.Update(graph, index_u, index_v);

      // Assert
      Assert.Equal(5          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);
    }

    [Fact]
    public void DoesNotUpdatePath()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();
      shortestPath.Reset();

      var graph = new int[,]
      {
        { 0, 0, 0 },
        { 3, 1, 0 },
        { 0, 7, 0 }
      };

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

      // Manipulate data for testing purposes.
      // These values will be set in the loop
      shortestPath.ResetDistanceOfSourceVertex(sourceVertexIndex: index_u);
      shortestPath.SetShortestDistance(index_u, value: 2);
      shortestPath.SetShortestDistance(index_v, value: 4); // v=4 is the reason to not to update

      // Pre-act 2
      Assert.Equal(4          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

      // Act
      shortestPath.Update(graph, index_u, index_v);

      // Assert
      Assert.Equal(4          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);
    }

    [Fact]
    public void GetMinimumDistancesIndexTest()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();
      shortestPath.Reset();
      shortestPath.ResetDistanceOfSourceVertex(1);

      // Act
      var minimumDistancesIndex = shortestPath.GetMinimumDistancesIndex();

      // Assert
      Assert.Equal(1, minimumDistancesIndex);
    }

    [Fact]
    public void GetMinimumDistancesIndexTest2()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath();
      shortestPath.Reset();
      shortestPath.ResetDistanceOfSourceVertex(5);

      // Act
      var minimumDistancesIndex = shortestPath.GetMinimumDistancesIndex();

      // Assert
      Assert.Equal(5, minimumDistancesIndex);
    }

  }
}