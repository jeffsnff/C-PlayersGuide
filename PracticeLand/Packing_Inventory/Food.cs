using System;

namespace PracticeLand
{
  internal class Food : InventoryItem
  {
    public Food(double weight = 1, double volume = 0.5) : base(weight, volume)
    {

    }
    public override string ToString()
    {
      return "Food";
    }
  }
}