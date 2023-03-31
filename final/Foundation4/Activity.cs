public class Activity
{
  private string _activityName;
  private string _date;
  private double _lengthInMinutes;

  public Activity(string activityName, string date, double lengthInMinutes)
  {
    _activityName = activityName;
    _date = date;
    _lengthInMinutes = lengthInMinutes;
  }

  public void DisplaySummary()
  {
    Console.WriteLine($"{_date} {_activityName} ({_lengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed().ToString("0.#")} mph, Pace: {GetPace().ToString("0.#")} min per mile");
  }

  public virtual double GetDistance()
  {
    return GetSpeed() * _lengthInMinutes;
  }

  public virtual double GetSpeed()
  {
    return (GetDistance() / _lengthInMinutes) * 60;
  }

  protected virtual double GetPace()
  {
    return 60 / GetSpeed();
  }
}
