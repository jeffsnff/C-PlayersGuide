using System;

namespace RPGCharacter{
  public class Character{
    private string name;
    private int health;
    private int mana;
    private string[] inventory;

    public Character(string name){
      this.name = name;
      this.health = 100;
      this.mana = 100;
      this.inventory = new string[5];
    }

    public override string ToString()
    {
      return $"{this.name} Health: {this.health} Mana: {this.mana}";
    }
  }
}