using System;

namespace PracticeLand
{
  internal class Bow : InventoryItem
  {
    public Bow(double weight = 1, double volume = 4) : base(weight, volume)
    {

    }

    public override string ToString()
    {
      return "Bow";
    }
  }
}