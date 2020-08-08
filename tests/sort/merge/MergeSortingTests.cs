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

    [Fact]
    public void MergeTest2()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{10, 11}, new List<int>{});

      // Assert
      Assert.Equal(new List<int>{10,11}, result);
    }

    [Fact]
    public void MergeTest3()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{}, new List<int>{20, 21});

      // Assert
      Assert.Equal(new List<int>{20,21}, result);
    }

    [Fact]
    public void DivideCollectionInTwoTest()
    {
      // Arrange
      var numbers = new List<int>{1,2,3,4};
      var expected = new List<int>{1,2};

      // Act
      var firstHalf = new MergeSorting().FirstHalfOfCollection(numbers);

      // Assert
      Assert.Equal(expected, firstHalf);
    }
  }
}