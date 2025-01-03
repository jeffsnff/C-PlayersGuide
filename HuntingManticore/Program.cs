using System;

namespace HuntingManticore

{
  internal class Program{
    static void Main(string[] args){
      int round = 1;
      int cityHealth = 15;
      int manticoreHealth = 10;

      // Set Range of Manicore
      int manticoreRange = SetRangeManicore();

      // Game Play
      while(manticoreHealth > 0 && cityHealth > 0){
        Status(round, cityHealth, manticoreHealth);
        manticoreHealth = Attack(manticoreRange, round, manticoreHealth);
        round++;
        if(manticoreHealth<=0){
          WinnerScreen();
        }
      }
      
    }

    public static int SetRangeManicore(){
      while(true){
        int minRange = 0;
        int maxRange = 100;

        // Clear and give some space in the console for easy reading
        Console.Clear();
        SetConsoleSpacing(4);

        // Player 1 sets Manticore range
        Console.Write("PLayer 1, how far away from the city do you want to station the Manticore? ");
       int manticoreRange = Convert.ToInt32(Console.ReadLine());
        if(manticoreRange < minRange || manticoreRange > maxRange){
          continue;
        }
        Console.Clear();
        return manticoreRange;
      }
    }

    public static void Status(int round, int cityHealth, int manticoreHealth){
      int cannonDamage = UpdateDamage(round);
      Console.WriteLine("-------------------------------------------------------------------------------------------------");
      Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
      Console.WriteLine($"This cannon is expected to deal {cannonDamage} damage this round.");
      Console.WriteLine();
      Console.WriteLine();
    }
    public static int TargetRange(){
      int targetRange;
      Console.Write("Enter desired cannon range: ");
      targetRange = Convert.ToInt32(Console.ReadLine());
      while(targetRange<0 || targetRange > 100){
        Console.WriteLine("That number is not valid. Enter a number between 0 - 100.");
        targetRange = Convert.ToInt32(Console.ReadLine());
      }
      return targetRange;
    }
    public static int CalcHealth(int round, int manticoreHealth){
      return manticoreHealth - UpdateDamage(round);
    }
    public static int Attack(int manticoreRange, int round, int manticoreHealth){
      int targetRange = TargetRange();
      if(targetRange !=manticoreRange){
        if(targetRange > manticoreRange){
          Console.WriteLine("You overshot the Manticore!");
        }
        if(targetRange < manticoreRange){
          Console.WriteLine("You undershot the Manticore!");
        }
        return manticoreHealth;
      }
      return CalcHealth(round, manticoreHealth);
    }
    public static int UpdateDamage(int round){
      if(round%3==0 && round%5==0){
        return 15;
      }
      if(round%3==0){
        return 3;
      }
      if(round%5==0){
        return 5;
      }
      return 1;
    }
    public static void WinnerScreen(){
      Console.Clear();
      SetConsoleSpacing(4);
      Console.WriteLine("Congratulations! You have destroyed the Manticore!");
      SetConsoleSpacing(4);
    }
    public static void SetConsoleSpacing(int spaces){
      for(int i=0;i<spaces;i++){
        Console.WriteLine();
      }
    }
  }
}