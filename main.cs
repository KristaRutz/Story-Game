using System;
using System.Collections.Generic;
using CharacterAbout.Models;
using Storyline.Models;


namespace DogGame
{

  public class Program
  {

    public static void Main()
    {
      Story.StartGame();
      Story.NameChar();
      Story.FirstChapter();
      Story.SecondChapter();
      Story.HappyEnd();
    }
  }
}