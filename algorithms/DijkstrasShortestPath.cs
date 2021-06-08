namespace practicing_algorithms.algorithms
{
  public class DijkstrasShortestPath
  {
    public int [] shortestDistances {get; private set;}
    public bool[] verticesThatAreInShortestDistance {get; private set;}
    private int[,] graph;

    public DijkstrasShortestPath(int[,] graph)
    {
      this.shortestDistances = new int[graph.GetLength(0)];
      this.verticesThatAreInShortestDistance = new bool[graph.GetLength(0)];
      this.graph = graph;
    }

    public void Find(int source)
    {
      this.Reset();
      this.ResetDistanceOfSourceVertex(source);
      this.FindShortestPath();
    }

    public void Reset()
    {
      for(var i=0; i<this.shortestDistances.Length; i++)
      {
        this.shortestDistances[i] = int.MaxValue;
        this.verticesThatAreInShortestDistance  [i] = false;
      }
    }

    public void ResetDistanceOfSourceVertex(int sourceVertexIndex) => this.shortestDistances[sourceVertexIndex] = 0;

    public void FindShortestPath()
    {
      for(var i=0; i<(this.shortestDistances.Length-1);  i++)
      {
        var u = GetMinimumDistancesIndex();
        this.verticesThatAreInShortestDistance[u] = true;
        UpdateDistances(u);
      }
    }

    public void UpdateDistances(int u)
    {
      for(var v=0; v<this.shortestDistances.Length; v++)
      {
        Update(u, v);
      }
    }

    public void SetShortestDistance(int index, int value) => shortestDistances[index] = value;

    public void Update(int u, int v)
    {
      if
      (
        !verticesThatAreInShortestDistance[v] &&
        graph[u, v] != 0 &&
        shortestDistances[u] != int.MaxValue &&
        shortestDistances[u] + graph[u, v] < shortestDistances[v]
      )
      {
        shortestDistances[v] = shortestDistances[u] + graph[u, v];
      }
    }

    public int GetMinimumDistancesIndex()
    {
      var minValue = int.MaxValue;
      var minIndex = -1;

      for(var v=0; v<this.shortestDistances.Length; v++)
      {
        if(this.verticesThatAreInShortestDistance[v]==false  &&  this.shortestDistances[v] <= minValue)
        {
          minValue = this.shortestDistances[v];
          minIndex = v;
        }
      }

      return minIndex;
    }

  }
}