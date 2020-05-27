using System;
using practicing_algorithms.algorithms.sort.exchange;
using Xunit;

namespace practicing_algorithms.tests.sort.exchange
{
  public sealed class OddEvenSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<NotImplementedException>( () => new OddEvenSorting(new int[0]).Sort() );
    }
  }
}
