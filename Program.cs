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
using Games.Riddles;

namespace AnotherDumbProgram {
  public class Program
  {
    public static void Main()
    {
      Sphinx s = new Sphinx();
      const string title = "##########################################\n" +
                           "#                                        #\n" +
                           "#           THE SPHINX AWAITS!           #\n" +
                           "#                                        #\n" +
                           "##########################################\n";

      // Loop to play as many times as we want
      Console.WriteLine(title);

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
          Console.WriteLine("You've won!");
          return;
        } else if (s.isOutOfTries()) {
          Console.WriteLine("You're out of tries, good luck next time!");
          return;
        } else if (answerCheck == true) {
          Console.WriteLine("You've answered the question correctly!");
        } else {
          Console.WriteLine("You're a dingus!");
        }
      }
    }
  }
}
