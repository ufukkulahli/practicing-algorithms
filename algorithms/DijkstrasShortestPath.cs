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

  }
}