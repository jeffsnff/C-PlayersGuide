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
      while(true){
        int minRange = 0;
        int maxRange = 100;
        Console.Write("PLayer 1, how far away from the city do you want to station the Manticore? ");
        manticoreRange = Convert.ToInt32(Console.ReadLine());
        if(manticoreRange < minRange || manticoreRange > maxRange){
          continue;
        }
        break;
      }

      // Display Status
      Status(round, cityHealth, cannonDamage);

    }

    public static void Status(int round, int cityHealth, int cannonDamage){
      Console.WriteLine("-------------------------------------------------------------------------------------------------");
      Console.Write($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {10}/10");
      Console.Write($"This cannon is expected to deal {cannonDamage} damage this round.");
    }
  }
}