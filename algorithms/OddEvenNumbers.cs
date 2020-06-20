using System.Collections.Generic;

namespace practicing_algorithms.algorithms
{
  public enum NumberGeneration { Odd, Even }

  public sealed class OddEvenNumbers
  {
    readonly int evenNumberGenerationStartFrom = -2;
    readonly int oddNumberGenerationStartFrom = -1;
    int currentNumber;

    public OddEvenNumbers(NumberGeneration ng)
    {
      if(ng == NumberGeneration.Odd)
      {
        this.currentNumber = oddNumberGenerationStartFrom;
        return;
      }
      this.currentNumber = evenNumberGenerationStartFrom;
    }

    public IEnumerable<int> GenerateUpTo(int limit)
    {
      while(HasNext(limit))
      {
        yield return currentNumber;
      }
    }

    bool HasNext(int limit)
    {
      currentNumber+=2;
      return currentNumber <= limit;
    }
  }
}
