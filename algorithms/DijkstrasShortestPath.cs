namespace practicing_algorithms.algorithms
{
  public class DijkstrasShortestPath
  {
    public int [] shortestDistances {get;} = new int[9];
    public bool[] verticesThatAreInShortestDistance   {get;} = new bool[9];

    public void Find(int[,] graph, int source)
    {
      throw new System.NotImplementedException();
    }

    public void Reset()
    {
      for(var i=0; i<9; i++)
      {
        this.shortestDistances[i] = int.MaxValue;
        this.verticesThatAreInShortestDistance  [i] = false;
      }
    }

    public void ResetDistanceOfSourceVertex(int sourceVertex) => this.shortestDistances[sourceVertex] = 0;

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

  }
}