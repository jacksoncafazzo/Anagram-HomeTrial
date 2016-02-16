using Xunit;
namespace AnagramDetector
{
  public class AnagramTest
  {
    [Fact]
    public void IsAnagram_WillReturnTrueIfLettersMatch_true()
    {
      Anagram newAnagram = new Anagram("score", "cores");
      Assert.Equal(true, newAnagram.IsAnagram());
    }
    [Fact]
    public void IsAnagram_WillReturnFalseIfLettersDontMatch_false()
    {
      Anagram newAnagram = new Anagram("score", "corey");
      Assert.Equal(false, newAnagram.IsAnagram());
    }
    // [Fact]
    // public void IsAnagram_GetAnAnagramToCheck_true()
    // {
    //   Anagram newAnagram = new Anagram();
    //   Assert.Equal('t', newAnagram.IsAnagram("thomas"));
    // }

  }
}
