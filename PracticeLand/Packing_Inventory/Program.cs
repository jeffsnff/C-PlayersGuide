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
      Bow bow = new Bow();
      Water water = new Water();
      Food food = new Food();
      Sword sword = new Sword();


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
                AddItem(backpack, bow);
                break;
              case 3:
                AddItem(backpack, rope);
                break;
              case 4:
                AddItem(backpack, water);
                break;
              case 5:
                AddItem(backpack, food);
                break;
              case 6:
                AddItem(backpack, sword);
                break;
            }
            break;
          case 2:
            // backpack.CurrentInventory();
            PrintPackInventory(backpack.CurrentInventory(), "Current Inventory is:");
            break;
          case 3:
            PackInfo(backpack.CurrentWeight(), "Current weight");
            break;
          case 4:
            PackInfo(backpack.CurrentVolume(), "Current volume");
            break;
          case 5:
            PackInfo(backpack.CurrentInventoryCount(), "Current Inventory Count");
            break;
          case 6:
            Console.WriteLine(backpack);
            Console.ReadKey();
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

    private static void PackInfo(double[] data, string message)
    {
      Console.WriteLine($"{message} is {data[0]} out of {data[1]}.");
      Console.ReadKey();
    }
    private static void PrintPackInventory(string[] inventory, string message)
    {
      Console.WriteLine(message);
      foreach (string item in inventory)
      {
        Console.WriteLine(item);
      }
      Console.ReadKey();
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
  enum Actions { Add, Check_Inventory, Check_Weight, Check_Volume, Count_Inventory, Pack_Information }
  enum Items {Arrow, Bow, Rope, Water, Food, Sword}
}