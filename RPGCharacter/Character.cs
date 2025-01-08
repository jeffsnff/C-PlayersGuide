using System;

namespace RPGCharacter
{
  public class Character
  {
    private string name;
    private int health;
    private int mana;
    private string[] inventory;

    public Character(string name)
    {
      this.name = name;
      this.health = 100;
      this.mana = 100;
      this.inventory = new string[5];
    }
    public void Attack(int userInput)
    {
      int damageDealt = RandomNumberGenerator(0, 10);

      if(userInput%2==0 && userInput%3==0){
          this.PlayerAttack(damageDealt);
          mana = mana - ManaUsed(damageDealt);
          this.Heal();
        }

        if(userInput%2==0){
          this.PlayerAttack(damageDealt);
          mana = mana - ManaUsed(damageDealt);
        }else{
          // User is attacked 
        }
    }
    internal void Heal()
    {
      if (this.health < 100 && this.inventory.Contains("Health_Potion"))
      {
        int healthAdded = RandomNumberGenerator(0, 10);
        if (this.health + healthAdded > 100)
        {
          this.health = 100;
        }
        this.health = this.health + healthAdded;
      }
      if (this.health < 100 && !this.inventory.Contains("Health_Potion"))
      {
        if (this.mana > 50)
        {
          this.health = 100;
          this.mana = this.mana - RandomNumberGenerator(20, 50);
        }
        this.health = 100;
        this.mana = this.RandomNumberGenerator(0, 10);
      }
      Console.WriteLine("You have healed yourself!");
    }

    internal int ManaUsed(int damageDealt)
    {
      if (damageDealt % 2 == 0)
      {
        return damageDealt / 2;
      }
      return 3;
    }
    internal int RandomNumberGenerator(int min, int max)
    {
      Random random = new Random();
      int randomNumber = random.Next(min, max);
      return randomNumber;
    }
    internal void PlayerAttack(int damageDealt)
    {
      Console.WriteLine($"Your have attacked! Dealing {damageDealt} damage!");
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine();
      }
    }
    public override string ToString()
    {
      return $"{this.name} Health: {this.health} Mana: {this.mana}";
    }
    public Boolean Dead()
    {
      if (this.health <= 0)
      {
        return true;
      }
      return false;
    }
  }
}