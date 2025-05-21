using System;

namespace The_Old_Robot
{
  public class WestCommand : IRobotCommand
  {
    public void Run(Robot robot)
    {
      if (robot.IsPowered) robot.X--;
    }
  }
}