namespace Palindrome.Domain
{
  public class PalindromeApp
  {
    string reverse = "";
    string word = "civix";

    public void CompareCharacters()
    {
      for (int i = word.Length - 1; i >= 0; i--)
      {
        reverse += word[i].ToString();
      }
      if (reverse == word)
        System.Console.WriteLine(word + " is a Palindrome");
      else
        System.Console.WriteLine(word + " Word is not a Palindrome");
    }

  }
}