using System;

namespace Vin_Fletchers_Arrows
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Arrow customerArrow;
      Console.Write("Do you want a custom arrow or premade arrow?\n1 - Custom\n2 - Premade\nInput Response: ");
      int userResponse = Convert.ToInt32(Console.ReadLine());

      if(userResponse == 1 || userResponse ==2)
      {
        switch (userResponse)
        {
          case 1:
            customerArrow = CustomArrow();
            break;
          default:
            customerArrow = PreMade();
            break;
        }
        Console.WriteLine($"Cost of Arrow: {customerArrow.GetCost():0.00}");
      }

      if(userResponse != 1 && userResponse != 2){
        Console.WriteLine("Invalid response! Program terminated!");
      }
    }

/// <summary>
/// Displays Enum for premade arrow types
/// </summary>
/// <returns>New premade arrow; Beginner, Marksman, Elite</returns>
    private static Arrow PreMade(){
      DisplayItems(Enum.GetNames(typeof(PreMade)), "Please select an Arrow type.");
      int choice = Convert.ToInt32(Console.ReadLine());
      switch(choice){
        case 1:
          return new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);
        case 2:
          return new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75);
        default:
          return new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65);
      }
    }
    private static Arrow CustomArrow()
    {
      ArrowHead arrowHead = GetArrowHead();
      Fletching fletching = GetFletching();
      int shaftLength = GetShaftLength();
      return new Arrow(arrowHead, fletching, shaftLength);
    }
    /// <summary>
    /// Calls another method DisplayItems which list out ArrowHead Enum values
    /// and ask the user what type of ArrowHead they want.
    /// </summary>
    /// <returns>Enum selection</returns>
    private static ArrowHead GetArrowHead()
    {
      DisplayItems(Enum.GetNames(typeof(ArrowHead)), "Please enter an Arrowhead type.");
      return (ArrowHead)Convert.ToInt32(Console.ReadLine());
    }
    /// <summary>
    /// Calls another method DisplayItems which list out Fletching Enum values
    /// and ask the user what type of fletching they want.
    /// </summary>
    /// <returns>Enum selection</returns>
    private static Fletching GetFletching()
    {
      DisplayItems(Enum.GetNames(typeof(Fletching)), "Please enter a Fletching type.");
      return (Fletching)Convert.ToInt32(Console.ReadLine());
    }
    /// <summary>
    /// Ask the user the length between 60 - 100cm.
    /// If number is outside those bounds, repeats question
    /// </summary>
    /// <returns>Int value of shaft length between 60 and 100</returns>
    private static int GetShaftLength()
    {
      Console.Write("Enter a length between 60 and 100 cm: ");
      int shaftLength = Convert.ToInt32(Console.ReadLine());
      if (shaftLength < 60 || shaftLength > 100)
      {
        return GetShaftLength();
      }
      return shaftLength;
    }
    /// <summary>
    /// Display item takes in a Enum that gets values that has been converted
    /// to a string array and a message to the user. Then displays the enum values.
    /// </summary>
    /// <param name="items">String Array</param>
    /// <param name="message">Message for the user</param>
    private static void DisplayItems(string[] items, string message)
    {
      Console.WriteLine(message);
      for (int i = 0; i < items.Length; i++)
      {
        Console.WriteLine($"{i + 1} - {items[i]}");
      }
      Console.Write("Input Response: ");
    }
  }
}