using Palindrome.Domain;
using Xunit;

namespace Palindrome.Testing
{
  public class UnitTest1
  {
    [Fact]
    public void Word_Is_Palindrome()
    {
      // Arrange
      var word = new PalindromeApp();
      var checkword = "civic";
      var expected = (word.CompareCharacters() == checkword);

      // Act
      var actual = (word.CompareCharacters() == checkword);

      // Assert
      Assert.True(expected == actual);
    }
  }
}
