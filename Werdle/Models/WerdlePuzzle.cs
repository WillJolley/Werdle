using System.Collections.Generic;
using System;

namespace Werdle.Models
{
 public class WerdlePuzzle
   {
      public string WordToGuess { get; set; }
      public string GuessedWord { get; set; }
      public List<char> IncorrectGuesses { get; set; }
      public int RemainingTries { get; set; } 
      public static Random random = new Random();

      // public WerdlePuzzle()
      // {
      //   public List<string> wordList = new List<string> {"window", "dog"};
      // }
   }
}