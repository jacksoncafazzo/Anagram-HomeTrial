using System;
using System.Collections.Generic;

namespace AnagramDetector
{
  public class Anagram
  {
    private string _word;
    private static List<string> _anagramAttempts = new List<string>();
    private static List<string> _anagrams = new List<string>();

    public Anagram(string firstWord, string anagram)
    {
      _word = firstWord;
      _anagramAttempts.Add(anagram);
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string word)
    {
      _word = word;
    }
    public static List<string> GetAnagrams()
    {
      return _anagramAttempts;
    }
    public static void AddAnagram(string anagram)
    {
      _anagrams.Add(anagram);
    }

    public bool IsAnagram()
    {
      string word = this.GetWord();
      string[] wordArray = word.Split();
      Array.Sort<string>(wordArray);
      List<string> anagrams = Anagram.GetAnagrams();
      foreach (string anagram in anagrams)
      {
        string[] anagramArray = anagram.Split();
        Array.Sort<string>(anagramArray);
        for (int i = 0; i < anagramArray.Length; i++)
        {
          if (wordArray[i] == anagramArray[i])
          {
            Console.WriteLine(i + "is a match");
          }
          else
          {
          return false;
          }
        }
        Anagram.AddAnagram(anagram);
      }
      return true;

    }
  }
}
