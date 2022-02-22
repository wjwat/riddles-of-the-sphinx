// Create a console application where the Sphinx asks a riddle and the user must
// answer the riddle correctly. If the riddle is answered correctly, the Sphinx
// asks a second riddle and so on.

//     Start with one riddle. If the user answers correctly, the Sphinx is
//     defeated. If the user is incorrect, the Sphinx eats the user.

//     Once the application is working with a single riddle, add a few more.

//     Try writing a method to randomize which riddle the Sphinx asks.

// Create Sphinx
// Get question
// Read Answer
// Check Question
// Ask next question, or show that you're a winner (Harry)

using System;
using System.Collections.Generic;
using Games.Riddles;

namespace AnotherDumbProgram {
  public class Program
  {
    public static void Main()
    {
      Dictionary<string, string> outPutStrings = new Dictionary<string, string>()
      {
        {"title", "\n" +
                  "     ##########################################\n" +
                  "     #                                        #\n" +
                  "     #           THE SPHINX AWAITS!           #\n" +
                  "     #                                        #\n" +
                  "     ##########################################\n" +
                  "\n" +
                  "             ANSWER THE QUESTIONS AND\n" +
                  "                 TEST YOUR METTLE\n"},
        {"winner", "\n" + 
                   "                ***************\n" +
                   "                * YOU'VE WON! *\n" +
                   "                ***************\n"},
        {"loser", "\n  SPHINX: You've Lost!"},
        {"correct", "\n  SPHINX: You got lucky this time, mortal!"},
        {"incorrect", "\n  SPHINX: I've met some idiots in my day, but you take the cake!"}
      };

      Sphinx s = new Sphinx();
      int riddleCount = 1;

      Console.WriteLine(outPutStrings["title"]);

      // Loop to play as many times as we want
      while (true) {
        // Is there a way to do this, and keep this string with the others in
        // our dictionary up above?
        string status = $"  SPHINX: You've got {s.GetTriesLeft()} tries left," +
          $" and {s.GetScore()} correct answers\n";

        Console.WriteLine(status);
        Console.WriteLine($"RIDDLE[{riddleCount}]: {s.getRiddle()}");
        Console.Write($"ANSWER[{riddleCount}]: ");
        string input = Console.ReadLine();

        bool answerCheck = s.checkAnswer(input);

        if (answerCheck == true && s.checkWinner() == true) {
          Console.WriteLine(outPutStrings["winner"]);
          return;
        } else if (s.isOutOfTries()) {
          Console.WriteLine(outPutStrings["loser"]);
          return;
        } else if (answerCheck == true) {
          Console.WriteLine(outPutStrings["correct"]);
        } else {
          Console.WriteLine(outPutStrings["incorrect"]);
        }
        riddleCount += 1;
      }
    }
  }
}
