using System;

namespace The_Locked_Door
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Door door = CreateDoor();
      Boolean doorClosed = true;

      while (doorClosed)
      {
        if (door._status.Equals(Status.Open))
        {
          doorClosed = DoorOpened();
          continue;
        }

        DoorStatus(door);
        Options userChoice = DisplayOptions(Enum.GetNames(typeof(Options)));

        if (userChoice.Equals(Options.Change_Password))
        {
          UpdatePassword(door);
          continue;
        }

        if (door._status.Equals(Status.Locked))
        {
          if (userChoice.Equals(Options.Unlock))
          {
            door.UpdateStatus(Status.Closed);
            continue;
          }
          Error(door, userChoice);
          continue;
        }

        if (door._status.Equals(Status.Closed))
        {
          if (userChoice.Equals(Options.Open))
          {
            door.UpdateStatus(Status.Open);
            continue;
          }
          if (userChoice.Equals(Options.Lock))
          {
            door.UpdateStatus(Status.Locked);
            continue;
          }
          Error(door, userChoice);
          continue;
        }
      }
    }




    private static Boolean DoorOpened()
    {
      Console.Clear();
      Console.WriteLine("Congratulations!\nYou have opened to the next level!");
      return false;
    }

    private static void DoorStatus(Door door)
    {
      Console.Clear();
      Console.WriteLine($"The Door is {door._status}");
      Console.WriteLine("What would you like to do?");
    }

    private static Options DisplayOptions(string[] options)
    {
      for (int i = 0; i < options.Length; i++)
      {
        Console.WriteLine($"{i + 1} - {options[i]}");
      }
      Console.Write("Response: ");
      return (Options)Convert.ToInt32(Console.ReadLine());
    }

    private static void UpdatePassword(Door door)
    {
      Console.Clear();
      Console.Write("What is your current password: ");
      string currentPassword = Console.ReadLine();
      Console.Write("What is your new password: ");
      string newPassword = Console.ReadLine();
      string response = door.ChangePassword(currentPassword, newPassword);
      Console.WriteLine(response);
      Console.ReadKey();
    }

    private static void Error(Door door, Options userChoice)
    {
      Console.Clear();
      Console.WriteLine($"{userChoice}ing is impossible!\nThe Door is {door._status}!");
      Console.ReadKey();
    }

    private static Door CreateDoor()
    {
      Console.Write("Enter a password for the door: ");
      return new Door(Console.ReadLine());
    }
  }
}