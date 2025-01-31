using System;

namespace Vin_Fletchers_Arrows
{
  internal class Arrow
  {
    private ArrowHead _arrowHead;
    private Fletching _fletching;
    private int _shaftLength;


    public Arrow(ArrowHead arrowHead, Fletching fletching, int shaftLength)
    {
      _arrowHead = arrowHead;
      _fletching = fletching;
      _shaftLength = shaftLength;
    }

    public float GetCost(){
      int arrowHeadCost = 0;
      int fletchingCost = 0;
      double shaftCost = _shaftLength * 0.5;
      switch(_arrowHead) {
        case ArrowHead.Obsidian:
          arrowHeadCost = 5;
          break;
        case ArrowHead.Steel:
          arrowHeadCost = 10;
          break;
        case ArrowHead.Wood:
          arrowHeadCost = 3;
          break;
      }

      switch(_fletching){
        case Fletching.GooseFeathers:
          fletchingCost = 3;
          break;
        case Fletching.TurkeyFeathers:
          fletchingCost = 5;
          break;
        case Fletching.Plastic:
          fletchingCost = 10;
          break;
      }
    
      return arrowHeadCost + fletchingCost + (float)shaftCost;
    }

    public override string ToString()
    {
      return $"ArrowHead: {_arrowHead}, Fletcing: {_fletching}, Shaft Length: {_shaftLength}";
    }
  }

  enum ArrowHead { Steel=1, Wood, Obsidian }
  enum Fletching { Plastic=1, TurkeyFeathers, GooseFeathers }
}