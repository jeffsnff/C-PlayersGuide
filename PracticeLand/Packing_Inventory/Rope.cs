using System;

namespace PracticeLand
{
  internal class Rope : InventoryItem
  {
    public Rope(double weight = 1, double volume = 1.5) : base(weight, volume)
    {

    }

    public override string ToString()
    {
      return "Rope";
    }
  }
}