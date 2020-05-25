using System;
using practicing_algorithms.algorithms.sort;
using Xunit;

namespace practicing_algorithms.tests.sort
{
  public sealed class BubbleSortTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<NotImplementedException>( () => new BubbleSort().Sort() );
    }
  }
}
