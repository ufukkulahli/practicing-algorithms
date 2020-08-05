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

    public IEnumerable<int> Merge(List<int> left, List<int> right)
    {
      List<int> result = new List<int>();

      var leftAny = left.Any();
      var rightAny = right.Any();
      int firstOfLeft = left.First();
      var firstOfRight = right.First();

      while (leftAny || rightAny)
      {
        if (leftAny && rightAny)
        {
          if (firstOfLeft <= firstOfRight)
          {
            result.Add(firstOfLeft);
            left.Remove(firstOfLeft);
          }
          else
          {
            result.Add(firstOfRight);
            right.Remove(firstOfRight);
          }
          continue;
        }

        if (leftAny)
        {
          result.Add(firstOfLeft);
          left.Remove(firstOfLeft);
          continue;
        }

        if (rightAny)
        {
          result.Add(firstOfRight);
          right.Remove(firstOfRight);
        }
      }
      return result;
    }
  }
}