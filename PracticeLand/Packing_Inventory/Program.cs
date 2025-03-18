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
      Arrow arrow = new Arrow();


      while (true)
      {
        int userAction = DisplayItems(Enum.GetNames(typeof(Actions)), "What would you like to do? ");
        switch (userAction)
        {
          case 1:
            int userInput = DisplayItems(Enum.GetNames(typeof(Items)), "What would you like to add?");
            switch (userInput)
            {
              case 1:
                AddItem(backpack, arrow);
                break;
              case 2:
                Console.WriteLine("Bow");
                Console.WriteLine("You added a Bow to your pack.");
                Console.ReadKey();
                break;
              case 3:
                AddItem(backpack, rope);
                break;
              case 4:
                Console.WriteLine("Water");
                Console.WriteLine("You added Water to your pack.");
                Console.ReadKey();
                break;
              case 5:
                Console.WriteLine("Food");
                Console.WriteLine("You added Food to your pack.");
                Console.ReadKey();
                break;
              case 6:
                Console.WriteLine("Sword");
                Console.WriteLine("You added a Sword to your pack.");
                Console.ReadKey();
                break;
            }
            break;
          case 2:
            backpack.CurrentInventory();
            Console.ReadKey();
            break;
          case 3:
            Console.WriteLine("Check Weight");
            Console.ReadKey();
            break;
          case 4:
            Console.WriteLine("Check Volume");
            Console.ReadKey();
            break;
          case 5:
            backpack.InventoryCount();
            Console.ReadLine();
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

    private static void AddItem(Pack backpack, InventoryItem item)
    {
      if (backpack.Add(item))
      {
        Console.WriteLine($"{item} was added to inventory");
        Console.ReadKey();
        return;
      }
      Console.WriteLine("Inventory is full!");
      Console.ReadKey();
    }
    private static int DisplayItems(string[] items, string message)
    {
      Console.Clear();
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
  enum Actions { Add, CheckInventory, CheckWeight, CheckVolume, CountInventory }
  enum Items {Arrow, Bow, Rope, Water, Food, Sword}
}