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
        {"title", "##########################################\n" +
                  "#                                        #\n" +
                  "#           THE SPHINX AWAITS!           #\n" +
                  "#                                        #\n" +
                  "##########################################\n"},
        {"winner", "\n" + 
                   "\t***************\n" +
                   "\t* You've Won! *\n" +
                   "\t***************\n"},
        {"loser", "\n\tSPHINX: You've Lost!\n"},
        {"correct", "\n\tSPHINX: You've answered the question correctly\n"},
        {"incorrect", "\n\tSPHINX: I've met some idiots in my day, but you take the cake!\n"}
      };


      Sphinx s = new Sphinx();
      // Loop to play as many times as we want
      Console.WriteLine(outPutStrings["title"]);

      // Loop forever unless a condition returns inside loop
      while (true) {
        // Add count to riddle to see which one we're on
        Console.WriteLine("RIDDLE: " + s.getRiddle());

        // Display score to see how many we've answered correctly & how many
        // tries you have left
        Console.Write("ANSWER: ");
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
      }
    }
  }
}
