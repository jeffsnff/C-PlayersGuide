using System;

namespace Triangle_Farmer
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        AddSpacing(5);
        int widgth = AskForNumber("Entering 0 Ends Program.\nEnter Triangle Base: ");
        if (widgth == 0)
        {
          break;
        }
        int height = AskForNumber("Enter the height of the triangle: ");
        int area = Area("triangle", height, widgth);
        Console.WriteLine($"The Area: {area}");
      }
    }
/// <summary>
/// Ask the user for a number
/// </summary>
/// <param name="question"></param>
/// <returns></returns>
    static int AskForNumber(string question)
    {
      Console.Write(question);
      int number = Convert.ToInt32(Console.ReadLine());
      return number;
    }

/// <summary>
/// Calculates the desired shapes area.
/// </summary>
/// <param name="shape"></param>
/// <param name="height"></param>
/// <param name="widgth"></param>
/// <returns></returns>
    static int Area(string shape, int height, int widgth){
      if(shape.Equals("triangle")){
        return (widgth * height) / 2;
      }
      return 0;
    }
/// <summary>
/// This adds new lines based on amountOfSpace
/// </summary>
/// <param name="amountOfSpace"></param>
    static void AddSpacing(int amountOfSpace)
    {
      for (int i = 1; i <= amountOfSpace; i++)
      {
        if (i == 1)
        {
          Console.WriteLine("------------------------------------------------------------");
        }
        Console.WriteLine();
      }
    }
  }
}