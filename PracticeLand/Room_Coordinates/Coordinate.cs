using System;
using System.Data;

namespace Room_Coordinates
{
  public struct Coordinate
  {
    public readonly int _row { get; } = 0;
    public readonly int _column { get; } = 0;

    public Coordinate(int row, int column)
    {
      _row = row;
      _column = _column;
    }
  }
}