using System;
using System.Net;
using System.Runtime.Versioning;

namespace PracticeLand
{
  internal class Program
  {
    static void Main(string[] args)
    {

      Console.Write("How many items do you want to carry? ");
      int inventorySize = Convert.ToInt32(Console.ReadLine());
      Console.Write("How much weight do you want to carry? ");
      uint maxWeight = Convert.ToUInt32(Console.ReadLine());
      Console.Write("How much volume do you want to carry? ");
      uint maxVolume = Convert.ToUInt32(Console.ReadLine());
      Pack backpack = new Pack(maxWeight, maxVolume, inventorySize);

      Rope rope = new Rope();


      while (true)
      {
        int userAction = DisplayItems(Enum.GetNames(typeof(Actions)), "What would you like to do? ");
        switch (userAction)
        {
          case 1:
            backpack.Add(rope);
            break;
          case 2:
            backpack.CurrentInventory();
            break;
          case 3:
            Console.WriteLine("Check Weight");
            break;
          case 4:
            Console.WriteLine("Check Volume");
            break;
          case 0:
            break;
        }

        // Once user is done with adding items to pack, carry on.
        if (userAction == 0)
        {
          Console.Clear();
          Console.WriteLine("You carry on with your adventure.");
          Console.ReadKey();
          break;
        }
      }
    }
    private static int DisplayItems(string[] items, string message)
    {
      int userInput;
      while (true)
      {
        Console.WriteLine(message);
        for (int i = 0; i < items.Length; i++)
        {
          Console.WriteLine($"{i + 1} - {items[i]}");
        }
        Console.Write("Input Response: ");
        try
        {
          userInput = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Clear();
          Console.WriteLine("You did not enter a number!");
          Console.ReadKey();
          continue;
        }
        
        if (userInput > items.Length || userInput < 0)
        {
          Console.Clear();
          Console.WriteLine("That is not an option!");
          Console.ReadKey();
          continue;
        }
        break;
      }
      return userInput;
    }
  }
  enum Actions {Add, CheckInventory, CheckWeight, CheckVolume}
}