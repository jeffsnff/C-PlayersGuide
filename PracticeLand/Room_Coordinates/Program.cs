using System;
using System.Security.Cryptography.X509Certificates;

namespace Room_Coordinates
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Coordinate coordA = new Coordinate(1, 2);
      Coordinate coordB = new Coordinate(0, 1);
      Coordinate coordC = new Coordinate(-1, 0);
      Coordinate coordD = new Coordinate(-4, -5);

      Console.WriteLine($"Expect: True Actual: {CoordAdjacent(coordA, coordB)}");
      Console.WriteLine($"Expect: True Actual: {CoordAdjacent(coordB, coordC)}");
      Console.WriteLine($"Expect: False Actual: {CoordAdjacent(coordC, coordD)}");
    }

    public static bool CoordAdjacent(Coordinate coordOne, Coordinate coordTwo)
    {
      if (
        coordOne._row - 1 == coordTwo._row ||
        coordOne._row + 1 == coordTwo._row ||
        coordOne._column - 1 == coordTwo._column ||
        coordOne._column + 1 == coordTwo._column
        )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}