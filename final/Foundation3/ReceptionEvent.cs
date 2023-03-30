public class ReceptionEvent : Event
{
  private string _emailtoRSVP;
  public ReceptionEvent(string title, string description, string date, string time, Address address, string emailtoRSVP) : base(title, description, date, time, address)
  {
    _emailtoRSVP = emailtoRSVP;
  }

  public override void displayFullDetails()
  {
    base.displayStandardDetails();
    Console.WriteLine($"Please confirm your attendace by the following email: {_emailtoRSVP}");
  }

}