using System.Collections.Generic;
using System.Linq;

namespace practicing_algorithms.algorithms.sort.merge
{
  public sealed class MergeSorting
  {
    public void Sort()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<int> DivideCollection(List<int> collection, int start, int end)
    {
      var output = new List<int>();

      for (var index = start; index < end; index++)
      {
        output.Add(collection[index]);
      }

      return output;
    }

    public IEnumerable<int> Merge(List<int> left, List<int> right)
    {
      List<int> result = new List<int>();

      while (left.Any() || right.Any())
      {
        if (left.Any() && right.Any())
        {
          if (left.First() <= right.First())
          {
            result.Add(left.First());
            left.Remove(left.First());
          }
          else
          {
            result.Add(right.First());
            right.Remove(right.First());
          }
        }

        else if (left.Any())
        {
          result.Add(left.First());
          left.Remove(left.First());
        }

        else if (right.Any())
        {
          result.Add(right.First());
          right.Remove(right.First());
        }
      }
      return result;
    }
  }
}