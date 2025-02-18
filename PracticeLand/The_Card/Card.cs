using System;
using System.ComponentModel;

namespace PracticeLand
{
  internal class Card
  {
    readonly Rank _rank;
    readonly Color _color;

    public Card(Rank rank, Color color)
    {
      _rank = rank;
      _color = color;
    }

    public override string ToString()
    {
      return $"The {_color} {_rank}";
    }

    public string CardType()
    {
      switch (_rank)
      {
        case Rank.Ampersand:
          return "This is a Face Card";
        case Rank.DollarSign:
          return "This is a Face Card";
        case Rank.Percent:
          return "This is a Face Card";
        case Rank.Power:
          return "This is a Face Card";
        default:
          return "This is a numbered card";
      }
    }
  }
  enum Color { Red, Green, Blue, Yellow };
  enum Rank
  {
    [Description("1")] One,
    [Description("2")] Two,
    [Description("3")] Three,
    [Description("4")] Four,
    [Description("5")] Five,
    [Description("6")] Six,
    [Description("7")] Seven,
    [Description("8")] Eight,
    [Description("9")] Nine,
    [Description("10")] Ten,
    [Description("&")] Ampersand,
    [Description("$")] DollarSign,
    [Description("%")] Percent,
    [Description("^")] Power
  }
}