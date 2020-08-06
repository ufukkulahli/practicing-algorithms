using Xunit;
using practicing_algorithms.algorithms.sort.merge;
using System.Collections.Generic;

namespace practicing_algorithms.tests.sort.merge
{
  public class MergeSortingTests
  {
    [Fact]
    public void Test()
    {
      Assert.Throws<System.NotImplementedException>( () => new MergeSorting().Sort() );
    }

    [Fact]
    public void MergeTest()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{10, 11}, new List<int>{20,21});

      // Assert
      Assert.Equal(new List<int>{10,11,20,21}, result);
    }
  }
}