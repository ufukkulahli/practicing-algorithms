using System.Collections.Generic;
using System.Linq;

namespace practicing_algorithms.algorithms.sort.merge
{
  public sealed class MergeSorting
  {
    public List<int> Sort(List<int> unorderedNumbers)
    {
      if (unorderedNumbers.Count <= 1)
      {
        return unorderedNumbers;
      }

      var midway = unorderedNumbers.Count / 2;
      var leftHalfOfCollection = DivideCollection(unorderedNumbers, 0, midway);
      var rightHalfOfCollection = DivideCollection(unorderedNumbers, midway, unorderedNumbers.Count);

      var newLeft = Sort(leftHalfOfCollection);
      var newRight = Sort(rightHalfOfCollection);
      return Merge(newLeft, newRight);
    }

    public List<int> DivideCollection(List<int> collection, int start, int end)
    {
      var output = new List<int>();

      for (var index = start; index < end; index++)
      {
        output.Add(collection[index]);
      }

      return output;
    }

    public List<int> Merge(List<int> left, List<int> right)
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