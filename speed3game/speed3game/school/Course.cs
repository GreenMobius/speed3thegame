namespace speed3game_core.player
{
  internal class Course
  {
    public string Code { get; set; } // e.g. CSSE120
    public string Professor { get; set; } //TODO: make class
    public int Credits { get; set; }
    public int Points { get; set; }
    public int Total { get; set; }

    public Course(string code, string prof, int credits) {
      Code = code;
      Professor = prof;
      Credits = credits;
      Points = 0;
      Total = 0;
    }

    public void AddScore(int points, int total)
    {
      Points += points;
      Total += total;
    }

    public float GetQualityPoints()
    {
      float score;
      int percentage = (100 * Points) / Total;
      switch (percentage)
      {
        case var _ when percentage >= 90:
          score = 4.0f;
          break;
        case var _ when percentage >= 85:
          score = 3.5f;
          break;
        case var _ when percentage >= 80:
          score = 3.0f;
          break;
        case var _ when percentage >= 75:
          score = 2.5f;
          break;
        case var _ when percentage >= 70:
          score = 2.0f;
          break;
        case var _ when percentage >= 65:
          score = 1.5f;
          break;
        case var _ when percentage >= 60:
          score = 1.0f;
          break;
        default:
          score = 0.0f;
          break;
      }
      return score * Credits;
    }
  }
}