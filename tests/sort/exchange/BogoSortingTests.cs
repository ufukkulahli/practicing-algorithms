using practicing_algorithms.algorithms.sort.exchange;
using Xunit;
using System;

namespace practicing_algorithms.tests.sort.exchange
{
  public class BogoSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange && Act && Assert
      Assert.Throws<NotImplementedException>( () => new BogoSorting().Sort() );
    }
  }
}
