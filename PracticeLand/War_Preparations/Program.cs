using System;

namespace War_Preperations
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Sword basic = new Sword(Material.Iron, Gemstone.None, 10, 2);
      Sword ironSapphire = basic with { gemstone = Gemstone.Sapphire };
      Sword binariumBitstone = basic with { gemstone = Gemstone.Bitstone, material = Material.Binarium };

      Console.WriteLine(basic);
      Console.WriteLine(ironSapphire);
      Console.WriteLine(binariumBitstone);
      Console.ReadKey();
    }
  }
}