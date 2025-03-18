using System;

namespace PracticeLand
{
  internal class Arrow : InventoryItem
  {
    public Arrow(double weight = 0.1, double volume = 0.05) : base(weight, volume)
    {

    }

    public override string ToString()
    {
      return "Arrow";
    }
  }
}