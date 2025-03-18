using System;
using System.Linq;

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

    // Report current item count

    // Report current volume

    // Report current weight

    // Report current inventory
    public void CurrentInventory()
    {
      foreach (InventoryItem item in this.inventory)
      {
        if (item.ToString() != "")
        {
          Console.WriteLine(item);
        }
        
      }
    }

    public override string ToString()
    {
      return $"This pack can carry a max weight of {this.maxWeight}, max volume of {this.maxVolume} and a maximum of {this.inventory.Length} items.";
    }
  }
}