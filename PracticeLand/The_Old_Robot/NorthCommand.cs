using System;

namespace The_Old_Robot
{
  public class NorthCommand : IRobotCommand
  {
    public void Run(Robot robot)
    {
      if (robot.IsPowered) robot.Y++;
    }
  }
}