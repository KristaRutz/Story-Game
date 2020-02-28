using System;
using System.Collections.Generic;
using CharacterAbout.Models;

namespace Storyline.Models
{
  public class Line
  {
    public static int Seconds = 2000;
    public static int QuickSeconds = 1000;

    public string Content { get; set; }
    public int Speed;

    public Line(string content, int speed)
    {
      Content = content;
      Speed = speed;
    }
  }
}