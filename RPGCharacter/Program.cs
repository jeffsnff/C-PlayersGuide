using System;

namespace RPGCharacter
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Character playerOne = new Character("Paola");
      
      while (true)
      {
        Console.WriteLine(playerOne);
        Console.Write("Enter a number between 1 and 100: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        playerOne.Attack(userInput);

        if (playerOne.Dead())
        {
          Console.WriteLine("You have died.");
          break;
        }
      }
    }
  }
}