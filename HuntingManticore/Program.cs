using System;
using System.Net.NetworkInformation;

namespace HuntingManticore
{
  internal class Program{
    static void Main(string[] args){
      int round = 1;
      int cityHealth = 15;
      int manticoreHealth = 10;
      int manticoreRange = 0;
      int cannonDamage = 1;
      

      // Set Range of Manicore
      manticoreRange = SetRangeManicore(manticoreRange);
      // Display Status
      Status(round, cityHealth, cannonDamage);

    }

    public static int SetRangeManicore(int manticoreRange){
      while(true){
        int minRange = 0;
        int maxRange = 100;
        Console.Write("PLayer 1, how far away from the city do you want to station the Manticore? ");
        manticoreRange = Convert.ToInt32(Console.ReadLine());
        if(manticoreRange < minRange || manticoreRange > maxRange){
          continue;
        }
        Console.Clear();
        return manticoreRange;
      }
    }

    public static void Status(int round, int cityHealth, int cannonDamage){
      Console.WriteLine("-------------------------------------------------------------------------------------------------");
      Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {10}/10");
      Console.WriteLine($"This cannon is expected to deal {cannonDamage} damage this round.");
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}