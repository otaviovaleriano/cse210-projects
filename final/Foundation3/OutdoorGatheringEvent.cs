public class OutdoorGatheringEvent : Event
{
  private string _weatherStatement;
  public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
  {
    _weatherStatement = weather;
  }

  public override void displayFullDetails()
  {
    base.displayStandardDetails();
    Console.WriteLine($"About the weather: {_weatherStatement}");
  }

}