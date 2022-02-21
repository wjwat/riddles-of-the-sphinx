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

      Console.WriteLine(s.getRiddle());
    }
  }
}
