using System;
using System.Linq;
using System.Collections.Generic;

namespace Games.Riddles
{
  public class Sphinx
  {
    private static Dictionary<string, string> _Riddles = new Dictionary<string, string>() {
      {"What is your age?", "25"},
      {"How many fingers do I have held up?", "4"},
      {"What have I got in my pocket?", "The One True Ring"},
      {"Fizz?", "Buzz"},
      {"Ding?", "Dong"},
      {"What is Epicodus?", "A school"},
      {"What is 10 * 2.5?", "25"},
      {"What is your favorite website?", "bananakingz.net"},
      {"What is the airspeed velocity of a swallow?", "African or European?"}
    };

    private int Score;
    private int Tries;
    private int IndexIntoQuestionOrder;
    private int MaxScore;
    private int MaxTries;
    private List<int> QuestionOrder;

    // MaxScore, MaxTries -- Set constructor to choose difficulty
    public Sphinx(int maxScore = 3, int maxTries = 5) {
      Score = 0;
      Tries = 0;
      IndexIntoQuestionOrder = 0;
      MaxScore = maxScore;
      MaxTries = maxTries;

      randomizeQuestionOrder();
    }

    public int GetTriesLeft() {
      return MaxTries - Tries;
    }
    public int GetScore() { return Score; }

    public string getRiddle()
    {
      string retValue = _Riddles.Keys.ElementAt(QuestionOrder[IndexIntoQuestionOrder]);

      return retValue;
    }

    public bool checkAnswer(string answer)
    {
      int i = QuestionOrder[IndexIntoQuestionOrder];
      IndexIntoQuestionOrder = (IndexIntoQuestionOrder == _Riddles.Count-1) ? 0 : IndexIntoQuestionOrder + 1;

      if (answer.ToUpper() == _Riddles.Values.ElementAt(i).ToUpper()) {
        Score += 1;
        return true;
      } else {
        Tries += 1;
        return false;
      }
    }

    public bool checkWinner() {
      return (Score >= MaxScore);
    }

    public bool isOutOfTries() {
      return (Tries >= MaxTries);
    }

    private void randomizeQuestionOrder() {
      Random rnd = new Random();
      List<int> numbers = new List<int>(Enumerable.Range(0, _Riddles.Count));
      QuestionOrder = numbers.OrderBy(a => rnd.Next()).ToList();
    }
  }
}
