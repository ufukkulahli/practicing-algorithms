using Xunit;
using practicing_algorithms.algorithms.sort.insertion;

namespace practicing_algorithms.tests.sort.insertion
{
  public class ShellSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var actualNumbers = new int[5]{5,4,3,2,1};
      var expectedNumbers = new int[5]{1,2,3,4,5};

      // Act
      new ShellSorting(actualNumbers).Sort();

      // Assert
      Assert.Equal(expectedNumbers, actualNumbers);
    }
  }
}
