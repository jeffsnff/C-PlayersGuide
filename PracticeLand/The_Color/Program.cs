using System;
using System.Drawing;

using The_Color;

namespace PracticeLand
{
  internal class Program
  {
    static void Main(string[] args)
    {
      NewColor a = new NewColor(127, 16, 9);
      NewColor b = NewColor.White();

      Console.WriteLine($"a: Red: {a.red}, Green: {a.green}, Blue: {a.blue}");
      Console.WriteLine($"b: Red: {b.red}. Green: {b.green}, Blue:{b.blue}");
    }
  }
}