using System;

namespace HuntingManticore
{
  internal class Program{
    static void Main(string[] args){
      int round = 1;
      int cityHealth = 15;
      int manticoreHealth = 10;
      int manticoreRange = 0;
      

      // This could be a function
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
    }
  }
}