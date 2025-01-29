using System;

namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] array = new int[5];
      int[] copyArray = new int[5];
      for(int i=0; i<array.Length; i++){
        Console.Write("Input a number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        array[i] = userNum;
      }

      int index = 0;
      foreach(int num in array){
        copyArray[index] = num;
        index++;
      }

      Console.WriteLine("copyArray contents are: ");
      foreach(int num in copyArray){
        Console.WriteLine(num);
      }
    }
  }
}