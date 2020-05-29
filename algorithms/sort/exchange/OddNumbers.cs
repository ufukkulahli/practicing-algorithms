using System.Collections.Generic;

namespace practicing_algorithms.algorithms.sort.exchange
{
  public sealed class OddNumbers
  {
    int currentOddNumber = -1;

    public IEnumerable<int> GenerateUpTo(int limit)
    {
      while(HasNext(limit))
      {
        yield return currentOddNumber;
      }
    }

    bool HasNext(int limit)
    {
      currentOddNumber+=2;
      return currentOddNumber <= limit;
    }
  }
}
