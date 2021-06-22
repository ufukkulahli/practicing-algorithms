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
    public void FindTest1()
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

      Assert.True (shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.True (shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
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
      shortestPath.ResetDistanceOfSourceVertex(1);

      // Assert
      this.AssertVerticesThatAreInShortestDistance(shortestPath);
      Assert.Equal(2147483647, shortestPath.shortestDistances[0]);
      Assert.Equal(0, shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647, shortestPath.shortestDistances[2]);
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

      // Act
      shortestPath.Update(index_u, index_v);

      // Assert
      Assert.Equal(4          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
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
      shortestPath.ResetDistanceOfSourceVertex(2);

      // Act
      var minimumDistancesIndex = shortestPath.GetMinimumDistancesIndex();

      // Assert
      Assert.Equal(2, minimumDistancesIndex);
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
    }

    private void AssertResults1(DijkstrasShortestPath shortestPath)
    {
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);

      Assert.False(shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
    }

    private void AssertResults2(DijkstrasShortestPath shortestPath)
    {
      Assert.Equal(9          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);

      Assert.False(shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
    }

    private void AssertResults3(DijkstrasShortestPath shortestPath)
    {
      Assert.Equal(5          , shortestPath.shortestDistances[0]);
      Assert.Equal(2          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);
    }

    private void AssertVerticesThatAreInShortestDistance(DijkstrasShortestPath shortestPath)
    {
      Assert.False(shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.False(shortestPath.verticesThatAreInShortestDistance[2]);
    }

    [Fact]
    public void FindTest2()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 4 , 0, 0 , 0 , 0 , 0, 8 , 0 },
        { 4, 0 , 8, 0 , 0 , 0 , 0, 11, 0 },
        { 0, 8 , 0, 7 , 0 , 4 , 0, 0 , 2 },
        { 0, 0 , 7, 0 , 9 , 14, 0, 0 , 0 },
        { 0, 0 , 0, 9 , 0 , 10, 0, 0 , 0 },
        { 0, 0 , 4, 0 , 10, 0 , 2, 0 , 0 },
        { 0, 0 , 0, 14, 0 , 2 , 0, 1 , 6 },
        { 8, 11, 0, 0 , 0 , 0 , 1, 0 , 7 },
        { 0, 0 , 2, 0 , 0 , 0 , 6, 7 , 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 0;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(0 , shortestPath.shortestDistances[0]);
      Assert.Equal(4 , shortestPath.shortestDistances[1]);
      Assert.Equal(12, shortestPath.shortestDistances[2]);
      Assert.Equal(19, shortestPath.shortestDistances[3]);
      Assert.Equal(21, shortestPath.shortestDistances[4]);
      Assert.Equal(11, shortestPath.shortestDistances[5]);
      Assert.Equal(9 , shortestPath.shortestDistances[6]);
      Assert.Equal(8 , shortestPath.shortestDistances[7]);
      Assert.Equal(14, shortestPath.shortestDistances[8]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[7]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[8]);
    }

    [Fact]
    public void FindTest3()
    {
      // Arrange
      int[,] graph =
      {
        {0, 1, 0, 3, 10},
        {1, 0, 5, 0, 0},
        {0, 5, 0, 2, 1},
        {3, 0, 2, 0, 6},
        {10,0, 1, 6, 0}
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 0;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(0 , shortestPath.shortestDistances[0]);
      Assert.Equal(1 , shortestPath.shortestDistances[1]);
      Assert.Equal(5 , shortestPath.shortestDistances[2]);
      Assert.Equal(3 , shortestPath.shortestDistances[3]);
      Assert.Equal(6 , shortestPath.shortestDistances[4]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
    }

    [Fact]
    public void FindTest4()
    {
      // Arrange
      int[,] graph =
      {
        {0,  10, 20, 0,  0,  0},
        {10, 0,  0,  50, 10, 0},
        {20, 0,  0,  20, 33, 0},
        {0,  50, 20, 0,  20, 2},
        {0,  10, 33, 20, 0,  1},
        {0,  0,  0,  2,  1,  0}
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 0;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(0  , shortestPath.shortestDistances[0]);
      Assert.Equal(10 , shortestPath.shortestDistances[1]);
      Assert.Equal(20 , shortestPath.shortestDistances[2]);
      Assert.Equal(23 , shortestPath.shortestDistances[3]);
      Assert.Equal(20 , shortestPath.shortestDistances[4]);
      Assert.Equal(21 , shortestPath.shortestDistances[5]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
    }

    [Fact]
    public void FindTest5()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 0 },
        { 0, 0, 0 },
        { 0, 0, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 0;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(0          , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
    }

    [Fact]
    public void FindTest6()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 0 },
        { 0, 0, 0 },
        { 0, 0, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 1;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(0          , shortestPath.shortestDistances[1]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[2]);

      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
    }

    [Fact]
    public void FindTest7()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 0 },
        { 0, 0, 0 },
        { 0, 0, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 2;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(2147483647 , shortestPath.shortestDistances[0]);
      Assert.Equal(2147483647 , shortestPath.shortestDistances[1]);
      Assert.Equal(0          , shortestPath.shortestDistances[2]);

      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
    }

    [Fact]
    public void FindTest8()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 0;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(0  , shortestPath.shortestDistances[0]);
      Assert.Equal(3  , shortestPath.shortestDistances[1]);
      Assert.Equal(1  , shortestPath.shortestDistances[2]);
      Assert.Equal(2  , shortestPath.shortestDistances[3]);
      Assert.Equal(4  , shortestPath.shortestDistances[4]);
      Assert.Equal(4  , shortestPath.shortestDistances[5]);
      Assert.Equal(3  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest9()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 1;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(3  , shortestPath.shortestDistances[0]);
      Assert.Equal(0  , shortestPath.shortestDistances[1]);
      Assert.Equal(2  , shortestPath.shortestDistances[2]);
      Assert.Equal(3  , shortestPath.shortestDistances[3]);
      Assert.Equal(5  , shortestPath.shortestDistances[4]);
      Assert.Equal(3  , shortestPath.shortestDistances[5]);
      Assert.Equal(4  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest10()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 2;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(1  , shortestPath.shortestDistances[0]);
      Assert.Equal(2  , shortestPath.shortestDistances[1]);
      Assert.Equal(0  , shortestPath.shortestDistances[2]);
      Assert.Equal(1  , shortestPath.shortestDistances[3]);
      Assert.Equal(3  , shortestPath.shortestDistances[4]);
      Assert.Equal(3  , shortestPath.shortestDistances[5]);
      Assert.Equal(2  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest11()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 3;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(2  , shortestPath.shortestDistances[0]);
      Assert.Equal(3  , shortestPath.shortestDistances[1]);
      Assert.Equal(1  , shortestPath.shortestDistances[2]);
      Assert.Equal(0  , shortestPath.shortestDistances[3]);
      Assert.Equal(4  , shortestPath.shortestDistances[4]);
      Assert.Equal(2  , shortestPath.shortestDistances[5]);
      Assert.Equal(1  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest12()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 4;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(4  , shortestPath.shortestDistances[0]);
      Assert.Equal(5  , shortestPath.shortestDistances[1]);
      Assert.Equal(3  , shortestPath.shortestDistances[2]);
      Assert.Equal(4  , shortestPath.shortestDistances[3]);
      Assert.Equal(0  , shortestPath.shortestDistances[4]);
      Assert.Equal(2  , shortestPath.shortestDistances[5]);
      Assert.Equal(3  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest13()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 5;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(4  , shortestPath.shortestDistances[0]);
      Assert.Equal(3  , shortestPath.shortestDistances[1]);
      Assert.Equal(3  , shortestPath.shortestDistances[2]);
      Assert.Equal(2  , shortestPath.shortestDistances[3]);
      Assert.Equal(2  , shortestPath.shortestDistances[4]);
      Assert.Equal(0  , shortestPath.shortestDistances[5]);
      Assert.Equal(1  , shortestPath.shortestDistances[6]);

      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindTest14()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 6;

      // Act
      shortestPath.Find(source);

      // Assert
      Assert.Equal(3  , shortestPath.shortestDistances[0]);
      Assert.Equal(4  , shortestPath.shortestDistances[1]);
      Assert.Equal(2  , shortestPath.shortestDistances[2]);
      Assert.Equal(1  , shortestPath.shortestDistances[3]);
      Assert.Equal(3  , shortestPath.shortestDistances[4]);
      Assert.Equal(1  , shortestPath.shortestDistances[5]);
      Assert.Equal(0  , shortestPath.shortestDistances[6]);

      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[0]);
      Assert.Equal(false , shortestPath.verticesThatAreInShortestDistance[1]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[2]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[3]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[4]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[5]);
      Assert.Equal(true  , shortestPath.verticesThatAreInShortestDistance[6]);
    }

    [Fact]
    public void FindFunctionThrowsException()
    {
      // Arrange
      int[,] graph =
      {
        { 0, 0, 1, 2, 0, 0, 0 },
        { 0, 0, 2, 0, 0, 3, 0 },
        { 1, 2, 0, 1, 3, 0, 0 },
        { 2, 0, 1, 0, 0, 0, 1 },
        { 0, 0, 3, 0, 0, 2, 0 },
        { 0, 3, 0, 0, 2, 0, 1 },
        { 0, 0, 0, 1, 0, 1, 0 }
      };
      var shortestPath = new DijkstrasShortestPath(graph);

      var source = 7;

      // Act & Assert
      Assert.Throws<System.IndexOutOfRangeException>( () => shortestPath.Find(source) );
    }

  }
}