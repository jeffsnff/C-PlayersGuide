using System;

namespace PracticeLand
{
  internal class Sword : InventoryItem
  {
    public Sword(double weight = 5, double volume = 3) : base(weight, volume)
    {

    }
    public override string ToString()
    {
      return "Sword";
    }
  }
}