using System;
using System.Collections.Generic;

namespace Storyline.Models
{
  public class Chapter
  {
    public int Number { get; set; }
    public Line[] Lines { get; set; }
    public static int Order { get; set; }

    public Chapter(int number, Line[] lines)
    {
      Number = number;
      Lines = lines;
      Order = SetOrder();
    }

    public static int SetOrder(){
      Order++;
      return Order;
    }
  }
}