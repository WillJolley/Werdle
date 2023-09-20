using System.Collections.Generic;
using System;

namespace Werdle.Models
{
  public class Guesses
  {
    public int GuessCount { get; set; }
    public char Guess { get; set; }
  

    public Guesses(char guess)
    {
      Guess = guess;
      GuessCount = 6;
    }
  }
}