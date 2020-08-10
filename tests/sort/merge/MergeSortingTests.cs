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
      // Arrange
      var numbers = new List<int>{4,3,2,1};
      var expected = new List<int>{1,2,3,4};

      // Act
      var actual = new MergeSorting().Sort(numbers);

      // Assert
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void MergeTwoCollections()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{10, 11}, new List<int>{20,21});

      // Assert
      Assert.Equal(new List<int>{10,11,20,21}, result);
    }

    [Fact]
    public void MergeTwoCollections_But_RightCollectionIsEmpty()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{10, 11}, new List<int>{});

      // Assert
      Assert.Equal(new List<int>{10,11}, result);
    }

    [Fact]
    public void MergeTwoCollections_But_LeftCollectionIsEmpty()
    {
      // Arrange && Act
      var result = new MergeSorting().Merge(new List<int>{}, new List<int>{20, 21});

      // Assert
      Assert.Equal(new List<int>{20,21}, result);
    }

    [Fact]
    public void DivideCollectionAndGetFirstHalfTest()
    {
      // Arrange
      var numbers = new List<int>{1,2,3,4};
      var expected = new List<int>{1,2};
      var midway = numbers.Count / 2;

      // Act
      var firstHalf = new MergeSorting().DivideCollection(numbers, 0, midway);

      // Assert
      Assert.Equal(expected, firstHalf);
    }

    [Fact]
    public void DivideCollectionAndGetRightHalfTest()
    {
      // Arrange
      var numbers = new List<int>{1,2,3,4};
      var expected = new List<int>{3,4};
      var midway = numbers.Count / 2;

      // Act
      var rightHalf = new MergeSorting().DivideCollection(numbers, midway, numbers.Count);

      // Assert
      Assert.Equal(expected, rightHalf);
    }
  }
}