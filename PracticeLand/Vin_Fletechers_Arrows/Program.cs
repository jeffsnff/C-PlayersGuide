using System;

namespace Vin_Fletchers_Arrows{
  internal class Program{
    static void Main(string[] args){

      ArrowHead arrowHead = GetArrowHead();
      Fletching fletching = GetFletching();
      int shaftLength = GetShaftLength();

      Arrow customerArrow = new Arrow(arrowHead, fletching, shaftLength);

      Console.WriteLine(customerArrow.ToString());
      Console.WriteLine($"{customerArrow.GetCost():0.00}");
    }
    /// <summary>
    /// Calls another method DisplayItems which list out ArrowHead Enum values
    /// and ask the user what type of ArrowHead they want.
    /// </summary>
    /// <returns>Enum selection</returns>
    public static ArrowHead GetArrowHead(){
      DisplayItems(Enum.GetNames(typeof(ArrowHead)), "Please enter an Arrowhead type.");
      return (ArrowHead)Convert.ToInt32(Console.ReadLine());
    }
    /// <summary>
    /// Calls another method DisplayItems which list out Fletching Enum values
    /// and ask the user what type of fletching they want.
    /// </summary>
    /// <returns>Enum selection</returns>
    public static Fletching GetFletching(){
      DisplayItems(Enum.GetNames(typeof(Fletching)), "Please enter a Fletching type.");
      return (Fletching)Convert.ToInt32(Console.ReadLine());
    }
    /// <summary>
    /// Ask the user the length between 60 - 100cm.
    /// If number is outside those bounds, repeats question
    /// </summary>
    /// <returns>Int value of shaft length between 60 and 100</returns>
    public static int GetShaftLength(){
      Console.WriteLine("Enter a length between 60 and 100 cm.");
      int shaftLength = Convert.ToInt32(Console.ReadLine());
      if(shaftLength<60 || shaftLength>100){
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
    public static void DisplayItems(string[] items, string message){
      Console.WriteLine(message);
      for(int i = 0;  i<items.Length; i++){
        Console.WriteLine($"{i+1} - {items[i]}");
      }
    }
  }
}