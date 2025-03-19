using System;
using System.Linq;
using System.Threading;

namespace PracticeLand
{
  internal class Pack
  {
    InventoryItem[] inventory;
    private uint maxWeight;
    private uint maxVolume;

    public Pack(uint maxWeight, uint maxVolume, int inventorySize)
    {
      this.maxWeight = maxWeight;
      this.maxVolume = maxVolume;
      this.inventory = new InventoryItem[inventorySize];
      for (int i = 0; i < this.inventory.Length; i++)
      {
        InventoryItem item = new InventoryItem(0.0, 0.0);
        this.inventory[i] = item;
      }
    }


    // bool Add method Ability to add to inventory if the item does not go over Packs max weight and max volume
    public bool Add(InventoryItem item)
    {
      double currentWeight = 0;
      double currentVolume = 0;
      int currentCount = 0;
      for (int i = 0; i < this.inventory.Length; i++)
      {
        currentWeight = currentWeight + this.inventory[i].weight;
        currentVolume = currentVolume + this.inventory[i].volume;
        if (this.inventory[i].weight != 0.0)
        {
          currentCount++;
        }
      }
      if (currentWeight + item.weight > maxWeight)
      {
        return false;
      }
      if (currentVolume + item.volume > maxVolume)
      {
        return false;
      }
      
      for (int i = 0; i < inventory.Length; i++)
      {
        if (this.inventory[i].weight == 0.0)
        {
          this.inventory[i] = item;
          return true;
        }
      }
      return false;
    }
    // Report current weight
    public double[] CurrentWeight()
    {
      double[] weightArray = new double[2];
      double weight = 0.0;
      foreach (InventoryItem item in this.inventory)
      {
        if (item.ToString() != "")
        {
          weight = weight + item.weight;
        }
      }
      weightArray[0] = weight;
      weightArray[1] = maxWeight;
      return weightArray;
    }

    // Report current volume
    public double[] CurrentVolume()
    {
      double[] volumeArray = new double[2];
      double volume = 0.0;
      foreach (InventoryItem item in this.inventory)
      {
        if (item.ToString() != "")
        {
          volume = volume + item.volume;
        }
      }
      // Console.WriteLine($"Current volume is {volume} out of {maxVolume}");
      volumeArray[0] = volume;
      volumeArray[1] = maxVolume;
      return volumeArray;
    }
    // Report current inventory
    public string[] CurrentInventory()
    {
      int count = 0;
      // Sets count to number that has actual item in this.inventory
      foreach (InventoryItem item in this.inventory)
      {
        if (item.ToString() != "")
        {
          count++;
        }
      }

      string[] items = new string[count];
      for (int i = 0; i < items.Count(); i++)
      {
        if (this.inventory[i].ToString() != "")
        {
          items[i] = this.inventory[i].ToString();
        }
      }
      return items;
    }
    // Report current item count
    public double[] CurrentInventoryCount()
    {
      double[] countArray = new double[2];
      int count = 0;
      foreach (InventoryItem item in this.inventory)
      {
        if (item.ToString() != "")
        {
          count++;
        }
      }
      countArray[0] = count;
      countArray[1] = this.inventory.Length;
      return countArray;
    }

    public override string ToString()
    {
      return $"This pack can carry a max weight of {this.maxWeight}, max volume of {this.maxVolume} and a maximum of {this.inventory.Length} items.";
    }
  }
}
