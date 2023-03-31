public class RunningActivity : Activity
{
  private double _distance;

  public RunningActivity(string activityName, string date, double lengthInMinutes, double distance) : base(activityName, date, lengthInMinutes)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }
}
