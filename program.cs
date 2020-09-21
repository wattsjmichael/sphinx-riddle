using System;
using System.Collections.Generic;
using Sphinx.Riddles;

namespace Sphinx {
  public class Program {
    public static void Main() {
      Riddle questionOne = new Riddle("I’m tall when I’m young, and I’m short when I’m old. What am I?", "a candle");

      Console.WriteLine(questionOne.Question);

      Console.WriteLine("what is your answer");
      string answer = Console.ReadLine ();

      if (answer.ToLower() == (questionOne.Answer).ToLower()) {
        Console.WriteLine("you won");
      } else {
        Console.WriteLine("you got eaten");
      }

    }
  }
}