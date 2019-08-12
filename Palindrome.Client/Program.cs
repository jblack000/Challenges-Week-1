using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      PalindromeApp CheckWord = new PalindromeApp();
      CheckWord.CompareCharacters();
    }
  }
}
