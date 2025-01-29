using System;

namespace BuyingInventory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string[] inventory = new string[] {"Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies"};
      int[] prices = new int[] {10, 15, 25, 1, 20, 200, 1};

      for (int i = 0; i < inventory.Length; i++)
      {
        Console.WriteLine($"{i + 1} - {inventory[i]}");
      }
      Console.Write("What number do you want to see the price of? ");
      int userInput = Convert.ToInt32(Console.ReadLine());

      Console.Write("What is your name? ");
      string userName = Console.ReadLine().ToLower();
      double price;

      price = userName switch{
        "jeff" => prices[userInput-1]*.5,
        _=> prices[userInput-1]
      };

      Console.WriteLine($"{inventory[userInput - 1]} cost {price} gold.");
    }
  }
}