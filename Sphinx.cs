using System;
using System.Linq;
using System.Collections.Generic;

namespace Games.Riddles
{
  public class Sphinx
  {
    private int Score;
    private int Tries;
    private string Answer;

    private static Dictionary<string, string> _Riddles = new Dictionary<string, string>()
    {
      {"What is your age?", "25"},
      {"How many fingers do I have held up?", "4"},
      {"What have I got in my pocket?", "The One True Ring"}
    };

    // MaxScore, MaxTries -- Set constructor to choose difficulty
    public Sphinx()
    {
      Score = 0;
      Tries = 0;
    }

    public string getRiddle()
    {
      var rand = new Random();
      int index = rand.Next(_Riddles.Count);
      Answer = _Riddles.Values.ElementAt(index);
      return _Riddles.Keys.ElementAt(index);
    }

    public bool checkAnswer(string answer)
    {
      if (answer.ToUpper() == Answer.ToUpper()) {
        Tries += 1;
        Score += 1;
        return true;
      } else {
        // Tries += 1;
        return false;
      }
    }

    public bool checkWinner() {
      if (Score == 3) {
        return true;
      } else {
        return false;
      }
    }

    public bool isOutOfTries() {
      if (Tries >= 5) {
        return true;
      } else {
        return false;
      }
    }
  }
}

// Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };
