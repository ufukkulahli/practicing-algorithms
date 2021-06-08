using practicing_algorithms.algorithms;
using Xunit;

namespace practicing_algorithms.tests
{
  public class DijkstrasShortestPathTests
  {
    private int[,] Graph()
    {
      return
        new int[,]
        {
          { 0, 0, 0 },
          { 3, 1, 0 },
          { 0, 7, 0 }
        };
    }

    [Fact]
    public void Test()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());

      var source = 1;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(3          , shortestPath.shortestDistances[0]);
      Assert.Equal(0          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

      Assert.True (shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.True (shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[6]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[7]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[8]);
    }

    [Fact]
    public void ResetAllDistancesToInfinite_And_ResetVisitedVertices()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());

      // Act
      shortestPath.Reset();

      // Assert
      this.AssertResults1(shortestPath);
    }

    [Fact]
    public void ResetSourceVertexDistance()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());

      // Act
      shortestPath.Reset();
      shortestPath.ResetDistanceOfSourceVertex(5);

      // Assert
      this.AssertVerticesThatAreInShortestDistance(shortestPath);
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
      var shortestPath = new DijkstrasShortestPath(Graph());
      shortestPath.Reset();

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      this.AssertResults1(shortestPath);

      // Manipulate data for testing purposes.
      // These values will be set in the loop
      shortestPath.ResetDistanceOfSourceVertex(sourceVertexIndex: index_u);
      shortestPath.SetShortestDistance(index_u, value: 2);
      shortestPath.SetShortestDistance(index_v, value: 9);

      // Pre-act 2
      this.AssertResults2(shortestPath);

      // Act
      shortestPath.Update(index_u, index_v);

      // Assert
      this.AssertResults3(shortestPath);
      this.AssertVerticesThatAreInShortestDistance(shortestPath);
    }

    [Fact]
    public void DoesNotUpdatePath()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());
      shortestPath.Reset();

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      this.AssertResults1(shortestPath);

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
      shortestPath.Update(index_u, index_v);

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
      var shortestPath = new DijkstrasShortestPath(Graph());
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
      var shortestPath = new DijkstrasShortestPath(Graph());
      shortestPath.Reset();
      shortestPath.ResetDistanceOfSourceVertex(5);

      // Act
      var minimumDistancesIndex = shortestPath.GetMinimumDistancesIndex();

      // Assert
      Assert.Equal(5, minimumDistancesIndex);
    }

    [Fact]
    public void UpdateDistancesTest()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      shortestPath.Reset();
      this.AssertResults1(shortestPath);


      // Pre-act 2
      // Manipulate data for testing purposes.
      // These values will be set in the loop
      shortestPath.ResetDistanceOfSourceVertex(sourceVertexIndex: index_u);
      shortestPath.SetShortestDistance(index_u, value: 2);
      shortestPath.SetShortestDistance(index_v, value: 9);
      this.AssertResults2(shortestPath);

      // Act
      shortestPath.UpdateDistances(index_u);

      // Assert
      this.AssertResults3(shortestPath);
      this.AssertVerticesThatAreInShortestDistance(shortestPath);
    }

    [Fact]
    public void FindShortestPathTest()
    {
      // Arrange
      var shortestPath = new DijkstrasShortestPath(Graph());

      var index_u = 1;
      var index_v = 0;

      // Pre-act 1
      shortestPath.Reset();
      this.AssertResults1(shortestPath);


      // Pre-act 2
      // Manipulate data for testing purposes.
      // These values will be set in the loop
      shortestPath.ResetDistanceOfSourceVertex(sourceVertexIndex: index_u);
      shortestPath.SetShortestDistance(index_u, value: 2);
      shortestPath.SetShortestDistance(index_v, value: 9);
      this.AssertResults2(shortestPath);

      // Act
      shortestPath.FindShortestPath();

      // Assert
      this.AssertResults3(shortestPath);
      Assert.True (shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.True (shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[6]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[7]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[8]);
    }

    private void AssertResults1(DijkstrasShortestPath shortestPath)
    {
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

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

    private void AssertResults2(DijkstrasShortestPath shortestPath)
    {
      Assert.Equal(9          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[3]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[4]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[5]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[6]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[7]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[8]);

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

    private void AssertResults3(DijkstrasShortestPath shortestPath)
    {
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

    private void AssertVerticesThatAreInShortestDistance(DijkstrasShortestPath shortestPath)
    {
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

  }
}