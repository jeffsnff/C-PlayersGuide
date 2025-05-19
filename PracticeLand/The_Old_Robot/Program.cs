using System;
using System.Data;

namespace The_Old_Robot
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The Old Robot");

      Robot robot = new Robot();
      for (int i = 0; i < robot.Commands.Length; i++)
      {
        string? input = Console.ReadLine();
        RobotCommand? command = input switch
        {
          "on" => new OnCommand(),
          "off" => new OffCommand(),
          "north" => new NorthCommand(),
          "east" => new EastCommand(),
          "west" => new WestCommand(),
          "south" => new SouthCommand(),
          _ => null
        };
        robot.Commands[i] = command;
      }

      robot.Run();
    }
  }
}