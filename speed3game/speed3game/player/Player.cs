using System;
using System.Collections.Generic;
using System.Text;

namespace speed3game_core.player
{
  class Player
  {
    private int _morale;
    private int _health;
    private int _strikes;

    public int Morale
    {
      get => _morale;
      set => _morale = Math.Min(Math.Max(value, 0), 100);
    }
    public int Health
    {
      get => _health;
      set => _health = Math.Min(Math.Max(value, 0), 100);
    }
    public int Year { get; set; }
    public int Strikes
    {
      get => _strikes;
      set => _strikes = Math.Min(Math.Max(value, 0), 3);
    }

    public List<Course> Courses { get; set; }

    public Player()
    {
      Morale = 75;
      Year = 1;
      Health = 90;
      Courses = new List<Course>();
    }

    public Boolean IsAlive()
    {
      return Morale >= 10 
        && Health >= 25
        && Gpa() >= 2.0f;
    }

    public float Gpa()
    {
      float points = 0;
      int total = 0;
      foreach(Course c in Courses)
      {
        points += c.GetQualityPoints();
        total += c.Credits;
      }
      return points / total;
    }

    public void Class(Course course)
    {
      ++course.Points;
      Health -= 5;
    }

    public void Study(Course course)
    {
      ++course.Points;
      Health -= 5;
    }

    public void Fun()
    {
      Morale += 5;
      Health -= 5;
    }

    public void Eat()
    {
      Morale += 5;
      Health += 10;
    }

    public void Sleep()
    {
      Morale += 1;
      Health += 10;
    }
  }
}
