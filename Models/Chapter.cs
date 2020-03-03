using System;
using System.Collections.Generic;

namespace Storyline.Models
{
  public class Chapter
  {
    public int Number { get; set; }
    public Line[] Lines { get; set; }
    public static int Order { get; set; }


    public static int instant = 0;
    public static int quick = 1;
    public static int normal = 2;

    public static string name = "Krista";
    public static string dogName = "Glady";

    private Line[] _linesOne = {new Line("..................", instant), new Line("[It's another Monday, and ~Chocolate Milk~ just isn't going to cut it tonight. Time to go pick up a few brews...]", normal), new Line($"Come on, {dogName}, hop in the car. We're going to the store.", normal), new Line("..................", instant), new Line("[At the store] Wait here buddy, I'll be right back. Just gotta grab a few things.", normal), new Line($"{dogName.ToUpper()}: Bark! Bark!", normal), new Line("I knew you'd understand, bud.", normal), new Line("..................", instant), new Line($"BERTHA: That gonna be all for you, {name}?", normal ), new Line("Yea, that's it, Bertha. Thanks.", normal), new Line("..................", instant), new Line("[You pay and exit the store.]", normal), new Line("What the #*@%?!!", quick), new Line("*SCREEEEEEEEAACHHHHH*", quick), new Line("That's my flippin' CAR, MAAAN!!", quick), new Line($"{dogName.ToUpper()}: Bark! Bark!", quick), new Line($"That a-hole got {dogName}! Hold on, I'm coming, buddy!!", normal), new Line("..................", instant)};

    private Line[] _linesTwo = {new Line("..................", instant), new Line($"I need a way to get to {dogName}.", normal), new Line("[You look around amd scan your enviorment. There are some skaters off in the parking lot and there's a bike tied up next to you.]", normal), new Line("..................", instant), new Line(">> DO YOU >> Ask the skaters for a board, or try and steal the bike next to you?", normal), new Line(">> Enter 'A' for skateboard or 'B' For bike", normal)};

    private Line[] _linesThree = {new Line("..................", instant), new Line("HEY Hey that dude just jacked my car. And my dog is in the back!! Gimmie your board so I can chase him down", normal), new Line("Wait so he jacked your car, so now your going to jack my board. Thats like a eye for an eye dude, not chill", normal), new Line("..................", instant), new Line($">> DO YOU >> try to convice these skater punks this for the greater good, or jack the board? After all, {dogName} is trapped in a car with a theif!", normal),new Line(">> Enter 'A' to choose to talk them into giving you the board or 'B' to choose  taking the board by force", normal)};

    public Chapter(int number, Line[] lines)
    {
      Number = number;
      Lines = lines;
      Order = SetOrder();
    }

   public void SetToChapterOne()
    {
      Lines = _linesOne;
    }
    public void SetToChapterTwo()
    {
      Lines = _linesTwo;
    }
    public void SetToChapterThree()
    {
      Lines = _linesThree;
    }

    public static int SetOrder(){
      Order++;
      return Order;
    }
  }
}