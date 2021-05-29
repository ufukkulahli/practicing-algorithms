namespace practicing_algorithms.algorithms
{
  public class DijkstrasShortestPath
  {
    public int [] shortestDistances {get;} = new int[9];
    public bool[] visitedVertices   {get;} = new bool[9];

    public void Find(int[,] graph, int source)
    {
      throw new System.NotImplementedException();
    }

    public void Reset()
    {
      for(var i=0; i<9; i++)
      {
        this.shortestDistances[i] = int.MaxValue;
        this.visitedVertices  [i] = false;
      }
    }

    public void ResetDistanceOfSourceVertex(int sourceVertex) => this.shortestDistances[sourceVertex] = 0;

    public void Update()
    {
      throw new System.NotImplementedException();
    }

  }
}