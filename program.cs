using System;
using System.Collections.Generic;

namespace Sphinx
{
  public class RiddleMeThis
  {
    public static void Question()
    {
      Console.WriteLine("I am the great an powerful Sphinx! Lowly mortal, answer my three questions to gain entry to this Castle.");
      Console.WriteLine("Question 1: How many fingers am I holding up?");
      int userInput1 = int.Parse(Console.ReadLine());
      int answer1 = 3;

      if (userInput1 != answer1)
      {
        Console.WriteLine("You have failed!!! Thank you for dinner! Get in my belly!!!! >:3");
      }
      else
      {
        Console.WriteLine("Grrr..... You have answered correctly!");
        Console.WriteLine("Question 2: Who played the role of Neo in The Matrix?");
        string userInput2 = Console.ReadLine().ToLower();
        string answer2 = "keanu reeves";
        
        if (userInput2 != answer2)
        {
          Console.WriteLine("You have failed!!! Thank you for dinner! Get in my belly!!!! >:3");
        }
        else
        {
          Console.WriteLine("Grrr..... You have answered correctly!");
          Console.WriteLine("Question 3: What belongs to you but others use it more than you?");
          string userInput3 = Console.ReadLine().ToLower();
          string answer3 = "your name";

          if (userInput3 != answer3)
          {
            Console.WriteLine("You have failed!!! Thank you for dinner! Get in my belly!!!! >:3");
          }
          else
          {
            Console.WriteLine("Grr.... I guess you have passed my 3 riddles... You may proceed...");
          }
        }
      }
    }
    static void Main()
    {
      Question();
    } 
  }
}