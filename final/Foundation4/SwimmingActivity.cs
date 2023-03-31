public class SwimmingActivity : Activity
{
  private int _lapsNum;

  public SwimmingActivity(string activityName, string date, double lengthInMinutes, int lapsNum) : base(activityName, date, lengthInMinutes)
  {
    _lapsNum = lapsNum;
  }

  public override double GetDistance()
  {
    // miles
    return _lapsNum * 50 / 1000 * 0.62;
  }
}
