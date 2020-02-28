using System;
using System.Collections.Generic;
using CharacterAbout;
using Storyline;


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