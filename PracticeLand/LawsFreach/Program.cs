using System;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

      int currentSmallest = int.MaxValue;
      foreach( int number in array){
        if(number<currentSmallest){
          currentSmallest = number;
        }
      }

      Console.WriteLine(currentSmallest);
    }
  }
}