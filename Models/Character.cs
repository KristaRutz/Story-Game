
using System;
using System.Collections.Generic;

namespace CharacterAbout.Models
{
  public class Character 
  {
    public string Name { get; set; }
    public string DogName { get; set; }
    public int CharLife { get; set; }
    public int DogLife { get; set; }
    public int MoralLevel { get; set; }

    public Character (string name, string dogName)
    { 
      Name = name;
      DogName = dogName;
      CharLife = 1;
      DogLife = 2;
      MoralLevel = 3;
    }

    public void DecreaseCharLife()
    {
      CharLife --;
    }

    public void IncreaseCharLife()
    {
      CharLife ++;
    }

    public void DecreaseDogLife()
    {
      DogLife --;
    }

    public void IncreaseDogLife()
    {
      DogLife ++;
    }

    public void DecreaseMoralLevel()
    {
      MoralLevel --;
    }

    public void IncreaseMoralLevel()
    {
      MoralLevel ++;
    }

    public void DisplayChar()
    {
      Console.Write($"{Name}, ");
      Console.Write($"Your moral level = {MoralLevel} ,");
      Console.Write($"your life level = {CharLife} ,");
      Console.WriteLine($"{DogName}'s life level = {DogLife}");
    }

  }

}

