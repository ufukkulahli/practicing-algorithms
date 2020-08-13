using practicing_algorithms.algorithms.sort.distribution;
using Xunit;

namespace practicing_algorithms.tests.sort.distribution
{
  public class RadixSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>(() => new RadixSorting().Sort());
    }

    [Fact]
    public void FindBiggestTest()
    {
      Assert.Equal(4, new RadixSorting().FindBiggest(new int[] { 1, 2, 3, 4 }));
    }
  }
}