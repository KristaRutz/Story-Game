using System;
using System.Collections.Generic;
using System.Threading;
using CharacterAbout.Models;


namespace Storyline.Models
{
  public class Story
  {
    public static Character newChar;
    
    public static void StartGame() 
      {
        Console.WriteLine("Do you want to start a new game? 'Y' for yes, 'N' for no");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
          Console.WriteLine("Your adventure begins...");
        }
        else if (answer == "n")
        {
          Console.WriteLine("Goodbye");
          System.Environment.Exit(0);
        }
        else
        {
          StartGame();
        }
      }

    public static void NameChar()
    {
      newChar = new Character("","");
      Console.WriteLine("What is your name?");
      newChar.Name = Console.ReadLine();
      Console.WriteLine("What's your dog's name?");
      newChar.DogName = Console.ReadLine();
    }

    public static void FirstChapter()
    {
      int instant = 0;
      int quick = 1;
      int normal = 2;
      string dogName = newChar.DogName;
      string name = newChar.Name;

      Line[] lines = {new Line("..................", instant), new Line("[It's another Monday, and ~Chocolate Milk~ just isn't going to cut it tonight. Time to go pick up a few brews...]", normal), new Line($"Come on, {dogName}, hop in the car. We're going to the store.", normal), new Line("..................", instant), new Line("[At the store] Wait here buddy, I'll be right back. Just gotta grab a few things.", normal), new Line($"{dogName.ToUpper()}: Bark! Bark!", normal), new Line("I knew you'd understand, bud.", normal), new Line("..................", instant), new Line($"BERTHA: That gonna be all for you, {name}?", normal ), new Line("Yea, that's it, Bertha. Thanks.", normal), new Line("..................", instant), new Line("[You pay and exit the store.]", normal), new Line("What the #*@%?!!", quick), new Line("*SCREEEEEEEEAACHHHHH*", quick), new Line("That's my flippin' CAR, MAAAN!!", quick), new Line($"{dogName.ToUpper()}: Bark! Bark!", quick), new Line($"That a-hole got {dogName}! Hold on, I'm coming, buddy!!", normal), new Line("..................", instant)}; 

      Chapter chapter = new Chapter(1, lines);

      for (int i = 0; i < chapter.Lines.Length; i++)
      {
        Console.WriteLine(chapter.Lines[i].Content);
        Thread.Sleep(chapter.Lines[i].Speed * 1000);
      }  
    }
    public static void SecondChapter()
    {
      int seconds = 2000;
      string dogName = newChar.DogName;
      Console.WriteLine($"I need a way to get to {dogName}.");
      Thread.Sleep(seconds);
      Console.WriteLine("[You look around amd scan your enviorment. There are some skaters off in the parking lot and there's a bike tied up next to you.]");
      Thread.Sleep(seconds);
      Console.WriteLine(">> DO YOU >> Ask the skaters for a board, or try and steal the bike next to you?");
      Thread.Sleep(seconds);
      Console.WriteLine(">> Enter 'A' for skateboard or 'B' For bike");
      Thread.Sleep(seconds);
      string answer =Console.ReadLine().ToLower();
      if  (answer == "a")
      {
        SkateBoardThirdChapter();
      }
      if (answer == "b")
      {
        BikeThirdChapter();
      }
    }

    public static void SkateBoardThirdChapter()
    {
      int seconds = 2000;
      string dogName = newChar.DogName;
      Console.WriteLine("HEY Hey that dude just jacked my car. And my dog is in the back!! Gimmie your board so I can chase him down");
      Thread.Sleep(seconds);
      Console.WriteLine("Wait so he jacked your car, so now your going to jack my board. Thats like a eye for an eye dude, not chill");
      Thread.Sleep(seconds);
      Console.WriteLine($"Do you try to convice these skater punks this for the greater good? Or jack the Board, after all {dogName} is trapped in a car with a theif!");
      Thread.Sleep(seconds);
      Console.WriteLine("Enter a to choose talking them into giving you the Board: Or b to choose to taking the Board");
      Thread.Sleep(seconds);
      string answer =Console.ReadLine().ToLower();
      if  (answer == "a")
      {
        newChar.IncreaseMoralLevel();
        newChar.DecreaseDogLife();
        Console.WriteLine("Your properties were changed");
        newChar.DisplayChar();
        FourthChapter();

       }
      if (answer == "b")
      {
        newChar.DecreaseMoralLevel();
        Console.WriteLine("Your properties were changed");
        newChar.DisplayChar();
        FourthChapter();
      }
    }

     public static void BikeThirdChapter()
      {
        int seconds = 2000;
        Console.WriteLine("The bike is tied up with only a rope, you break a beer bottle and use the sharp edge to cut through the rope.");
        Thread.Sleep(seconds);
        newChar.IncreaseMoralLevel();
        Console.WriteLine("Your properties were changed");
        newChar.DisplayChar();
        CheckLevel();
        FourthChapter();
      }
      public static void FourthChapter()
      {
        int seconds = 2000;
        Console.WriteLine("The car headed off around the park. Cut through the park or take the street?");
        Thread.Sleep(seconds);
        Console.WriteLine("a for street : b for park");
        string answer =Console.ReadLine().ToLower();
        if  (answer == "a")
        {
          StreetFifthChapter();

        }
        if (answer == "b")
        {
          ParkFifthChapter();
        }
      }

      public static void ParkFifthChapter(){
        int seconds = 2000;
        Console.WriteLine("The park is my best bet");
        Thread.Sleep(seconds);
        Console.WriteLine("You tear through the park doding pedistrains and bushes");
        Thread.Sleep(seconds);
        Console.WriteLine("Oh no! a suicidal squirrel jumps out in front of you. Theres no time to swerve you either have to crash or run over this depravied creature");
        Thread.Sleep(seconds);
        Console.WriteLine( "a for crash your bike: b for run over the squirel");
        Thread.Sleep(seconds);
        string answer =Console.ReadLine().ToLower();
        if (answer == "a")
       {
          newChar.IncreaseMoralLevel();
          newChar.DecreaseCharLife();
          newChar.DecreaseDogLife();
          Console.WriteLine("Your properties were changed");
          newChar.DisplayChar();
          CheckLevel();
       }
        if (answer == "b")
        {
          newChar.DecreaseMoralLevel();
          Console.WriteLine("Your properties were changed");
          newChar.DisplayChar();
          CheckLevel();

        }
      }

      public static void StreetFifthChapter(){
        int seconds = 2000;
        Console.WriteLine("Got to keep to the street");
        Thread.Sleep(seconds);
        Console.WriteLine("You swearve through traffic and pedistrians");
        Thread.Sleep(seconds);
        Console.WriteLine("Oh snap! This light is about to turn red, but it looks like I might make it");
        Thread.Sleep(seconds);
        Console.WriteLine( "a to stop at the light: b to blow the red");
        string answer =Console.ReadLine().ToLower();
        if (answer == "a")
        {
          newChar.DecreaseDogLife();
          Console.WriteLine("Your properties were changed");
          newChar.DisplayChar();
          CheckLevel();
        }
        if (answer == "b")
        {
          newChar.DecreaseCharLife();
          Console.WriteLine("Your properties were changed");
          newChar.DisplayChar();
          CheckLevel();
        }
      }

      public static void CheckLevel()
      {
        if (newChar.DogLife <= 0)
        {
          UnhappyEndDog();
        }
        else if (newChar.MoralLevel <= 0)
        {
          UnhappyEndMoral();
        }
        else if(newChar.CharLife <=0)
        {
          UnhappyEndChar();
        }

      }

      public static void UnhappyEndDog()
      {
        int seconds = 2000;
        string dogName = newChar.DogName;
        Console.WriteLine($"Your too slow, as you go after the car you see {dogName} reach his head out the window one last time");
        Thread.Sleep(seconds);
        Console.WriteLine("Bark Bark he/she calls out to you");
        Thread.Sleep(seconds);
        Console.WriteLine($"The sadness in {dogName}s barks will haunt you till you pass into the grave");
        Thread.Sleep(seconds);
        Console.WriteLine("Game Over");
        System.Environment.Exit(0);
      }
      public static void UnhappyEndMoral()
      {
        int seconds = 2000;
        Console.WriteLine("Turns out the Greeks got it right, who would have guessed. Zeus has been watching your actions closely"); 
        Thread.Sleep(seconds);
        Console.WriteLine("And after seeing all this messed up stuff you've been pulling pulls a thunderbolt from the sky and smites you where you stand.");
        Thread.Sleep(seconds);
        Console.WriteLine("GAME OVER");
        System.Environment.Exit(0);
      }

      public static void UnhappyEndChar()
      {
        int seconds = 2000;
        Console.WriteLine("Ouch, you Splat into the grave");
        Thread.Sleep(seconds);
        Console.WriteLine("GAME OVER");
      }

      public static void HappyEnd()
      {
        int seconds = 2000;
        string dogName = newChar.DogName;
        Console.WriteLine("After booking it you see your Car rounding the corner");
        Thread.Sleep(seconds);
        Console.WriteLine("Yo My Dog is in there, come on man dont be like that");
        Thread.Sleep(seconds);
        Console.WriteLine($"Come on {dogName} get out of there");
        Thread.Sleep(seconds);
        Console.WriteLine($"{dogName} jumps out the window of the car and lands gracefully on the pavenent and bounds over to you");
        Thread.Sleep(seconds);
        Console.WriteLine("You might have lost your whip, but you got your dog");
        Thread.Sleep(seconds);
        Console.WriteLine($"Theres probably a lesson there, or something like that but for now lets just go home {dogName}");
        
      }
  }

}
