using System;

namespace PracticeLand
{
  internal class Program
  {
    static void Main(string[] args)
    {
      foreach (Color color in Enum.GetValues(typeof(Color)))
      {
        foreach (Rank rank in Enum.GetValues(typeof(Rank)))
        {
          Card newCard = new Card(rank, color);
          Console.WriteLine(newCard);
        }
      }
    }
  }
}