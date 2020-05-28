using System.Collections.Generic;

public sealed class EvenNumbers
{
  int currentEvenNumber = -2;

  public IEnumerable<int> GenerateUpTo(int limit)
  {
    while(HasNext(limit))
    {
      yield return currentEvenNumber;
    }
  }

  bool HasNext(int limit)
  {
    currentEvenNumber+=2;
    return currentEvenNumber <= limit;
  }
}
