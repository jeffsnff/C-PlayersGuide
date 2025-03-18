using System;

namespace PracticeLand
{
  internal class InventoryItem
  {
    public double weight = 0.0;
    public double volume = 0.0;

    public InventoryItem(double weight, double volume)
    {
      this.weight = weight;
      this.volume = volume;
    }

    public override string ToString()
    {
      return "";
    }
  }
}