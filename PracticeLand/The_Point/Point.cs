using System;

namespace The_Point
{
  internal class Point
  {
    private readonly int _x;
    private readonly int _y;

    public Point(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public Point()
    {
      _x = 0;
      _y = 0;
    }

    public override string ToString()
    {
      return $"({_x},{_y})";
    }
  }
}