namespace practicing_algorithms.algorithms
{
  public class DijkstrasShortestPath
  {
    public int [] shortestDistances {get;} = new int[9];
    public bool[] verticesThatAreInShortestDistance   {get;} = new bool[9];

    public void Find(int[,] graph, int source)
    {
      this.Reset();
      this.ResetDistanceOfSourceVertex(0);
      this.FindShortestPath(graph);
    }

    public void Reset()
    {
      for(var i=0; i<9; i++)
      {
        this.shortestDistances[i] = int.MaxValue;
        this.verticesThatAreInShortestDistance  [i] = false;
      }
    }

    public void ResetDistanceOfSourceVertex(int sourceVertexIndex) => this.shortestDistances[sourceVertexIndex] = 0;

    public void FindShortestPath(int[,] graph)
    {
      for(var i=0; i<(graph.GetLength(0)-1);  i++)
      {
        var u = GetMinimumDistancesIndex();
        this.verticesThatAreInShortestDistance[u] = true;
        UpdateDistances(graph, u);
      }
    }

    public void UpdateDistances(int[,] graph, int u)
    {
      for(var v=0; v<graph.GetLength(0); v++)
      {
        Update(graph, u, v);
      }
    }

    public void SetShortestDistance(int index, int value) => shortestDistances[index] = value;

    public void Update(int[,] graph, int u, int v)
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

      for(var v=0; v<9; v++)
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