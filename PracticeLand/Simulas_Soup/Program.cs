using System;

namespace Simulas_Soup
{
  internal class Program
  {
    static void Main(string[] args)
    {
      (Soups soup, Ingredients ingredient, Seasoning season) userSoup;

      Soups soup = GetSoup();
      Ingredients ingredient = GetIngredients();
      Seasoning season = GetSeasoning();

      userSoup = (soup, ingredient, season);

      Console.WriteLine($"{userSoup.season} {userSoup.ingredient} {userSoup.soup} coming right up!");
    }
    /// <summary>
    /// Ask user for the type of soup they want based on Soups ENUM
    /// </summary>
    /// <returns>Enum value from Soups</returns>
    static Soups GetSoup()
    {
      int userInput = DisplayMenu(Enum.GetNames(typeof(Soups)), "Soup");
      if (CheckInput(userInput))
      {
        return (Soups)userInput;
      }
      return GetSoup();
    }
    /// <summary>
    /// Ask the user for the type of ingredient they want
    /// </summary>
    /// <returns>ENUM value from Ingredients</returns>
    static Ingredients GetIngredients()
    {
      int userInput = DisplayMenu(Enum.GetNames(typeof(Ingredients)), "Ingredient");
      if (CheckInput(userInput))
      {
        return (Ingredients)userInput;
      }
      return GetIngredients();
    }
    /// <summary>
    /// Ask user for type of seasoning
    /// </summary>
    /// <returns>ENUM value from Seasoning</returns>
    static Seasoning GetSeasoning()
    {
      int userInput = DisplayMenu(Enum.GetNames(typeof(Seasoning)), "Seasoning");
      if (CheckInput(userInput))
      {
        return (Seasoning)userInput;
      }
      return GetSeasoning();
    }
    public static int DisplayMenu(string[] items, string itemSelection)
    {
      for (int space = 1; space < 3; space++)
      {
        Console.WriteLine();
      }
      Console.WriteLine($"What type of {itemSelection} would you like?");
      for (int i = 0; i < items.Length; i++)
      {
        Console.WriteLine($"{i + 1} - {items[i]}");
      }
      Console.Write("Selection: ");
      return Convert.ToInt32(Console.ReadLine());
    }
    static Boolean CheckInput(int userInput)
    {
      if (Enum.IsDefined(typeof(Seasoning), userInput))
      {
        return true;
      }
      return false;
    }

  }

  enum Soups { Soup = 1, Stew, Gumbo }
  enum Ingredients { Mushrooms = 1, Chicken, Carrots, Potatoes }
  enum Seasoning { Spicy = 1, Salty, Sweet }
}