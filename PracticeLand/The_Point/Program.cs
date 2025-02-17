using System;

namespace The_Point
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Point firstPoint = new Point(2, 3);
      Point secondPoint = new Point(-4, 0);

      Console.WriteLine("First Point" + firstPoint);
      Console.WriteLine($"Second Point {secondPoint}");
    }
  }
}