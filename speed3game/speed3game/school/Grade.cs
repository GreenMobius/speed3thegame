using System;
using System.Collections.Generic;
using System.Text;

namespace speed3game_core.school
{
  class Grade
  {
    int Points;
    int Total;

    public Grade()
    {
      Points = 0;
      Total = 0;
    }

    public void AddScore(int points, int total)
    {
      Points += points;
      Total += total;
    }

    public int GetGrade()
    {
      return (100 * Points) / Total;
    }
  }
}
