using System;

using Colored_Items;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);

      ColoredItem<String> hello = new ColoredItem<string>("Hello World", ConsoleColor.DarkRed);

      hello.Display();
      Console.ReadKey();
    }
  }
}