using System;

namespace DefenseConsola
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Target row: ");
      int targetRow = Convert.ToInt32(Console.ReadLine());
      Console.Write("Target column: ");
      int targetColumn = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("(Row, Column)");
      Console.WriteLine($"({targetRow+1},{targetColumn})");
      Console.WriteLine($"({targetRow},{targetColumn+1})");
      Console.WriteLine($"({targetRow-1},{targetColumn})");
      Console.WriteLine($"({targetRow},{targetColumn-1})");
    }
  }
}