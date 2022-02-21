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
      {"ping", "2"},
      {"pong", "4"},
      {"fizz", "6"}
    };

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
        return true;
      } else {
        return false;
      }
    }
  }
}

// Dictionary<string, string> myDictionary = new Dictionary<string, string>() { {"A", "apple"}, {"B", "bear"} };
