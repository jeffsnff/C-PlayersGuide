using System;

using Microsoft.VisualBasic;

namespace The_Password_Validator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Clear();
        Console.Write("Type a Password: ");
        string userPassword = Console.ReadLine();
        PasswordValidator validatePassword = new PasswordValidator(userPassword);
        Console.WriteLine(validatePassword.Validator());
        Console.ReadKey();
      }
    }
  }
}