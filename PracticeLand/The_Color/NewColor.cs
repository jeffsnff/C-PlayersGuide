using System;
using System.Dynamic;

namespace The_Color
{
  internal class NewColor
  {
    public byte red;
    public byte green;
    public byte blue;

    public NewColor(byte red, byte green, byte blue)
    {
      this.red = red;
      this.green = green;
      this.blue = blue;
    }

    public static NewColor White()
    {
      return new NewColor(255, 255, 255);
    }
  }
}