using System;

namespace PracticeLand
{
  internal class Water : InventoryItem
  {
    public Water(double weight = 2, double volume = 3) : base(weight, volume)
    {

    }
    public override string ToString()
    {
      return "Water";
    }
  }
}