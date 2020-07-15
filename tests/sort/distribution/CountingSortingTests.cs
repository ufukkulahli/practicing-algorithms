using Xunit;
using practicing_algorithms.algorithms.sort.distribution;

namespace practicing_algorithms.tests.sort.exchange
{
  public class CountingSortingTests
  {
    [Fact]
    public void Test()
    {
      // Arrange
      var actualNumbers = new int[5]{5,4,3,2,1};
      var expectedNumbers = new int[5]{1,2,3,4,5};

      // Act
      // TODO

      // Assert
      Assert.Throws<System.NotImplementedException>( () => new CountingSorting(actualNumbers).Sort() );
    }
  }
}

