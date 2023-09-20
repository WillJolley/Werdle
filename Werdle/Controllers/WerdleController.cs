using Microsoft.AspNetCore.Mvc;
using Werdle.Models;
using System.Collections.Generic;

namespace Werdle.Controllers
{
   public class WerdleController : Controller
   {
      private WerdlePuzzle game;

      public IActionResult Index()
      {
       game = new WerdlePuzzle();
       return View(game);
      }  

      [HttpPost]
      public IActionResult Guess(string letter)
      {
       if (game.RemainingTries <= 0)
       {
        return RedirectToAction("GameOver");
       }

      char guess = letter.ToLower()[0];
      if (game.GuessedWord.Contains(guess) || game.IncorrectGuesses.Contains(guess))
      {
         TempData["Message"] = "You've already guessed that letter. Try again.";
      }
      else if (game.WordToGuess.Contains(guess))
      {
       for (int i = 0; i < game.WordToGuess.Length; i++)
       {
          if (game.WordToGuess[i] == guess)
          {
             game.GuessedWord = game.GuessedWord.Remove(i, 1).Insert(i, guess.ToString());
          }
       }
      }
      else
      {
       game.RemainingTries--;
       game.IncorrectGuesses.Add(guess);
      }

      if (game.RemainingTries <= 0)
      {
         return RedirectToAction("GameOver");
      }

        return View("Index", game);
      }

      public IActionResult GameOver()
      {
         return View(game);
      }

      public IActionResult GameWon()
        {
            return View(game);
        }
   }
}