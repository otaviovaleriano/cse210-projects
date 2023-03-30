class Program
{
  static void Main(string[] args)
  {
    List<Event> events = new List<Event>();
    Console.WriteLine("EVENT PLANNING APP");
    Console.WriteLine("*****************");

    //creating address
    Address address1 = new Address("123 Main Street", "New York", "NY", "10001");
    Address address2 = new Address("456 Broad Street", "Los Angeles", "CA", "90001");
    Address address3 = new Address("789 Oak Avenue", "Chicago", "IL", "60601");
    //creating Lecture Event
    LectureEvent event1 = new LectureEvent("Art of Cooking", "Learn the art of cooking from world-renowned chefs", "Oct 15th", "14:00", address1, "John Smith", 50);
    //creating Reception Event
    ReceptionEvent event2 = new ReceptionEvent("Holiday Party", "Celebrate the holidays with family and friends", "Dec 23rd", "19:00", address2, "rsvp@events.com");
    //creating Outgathering Event
    OutdoorGatheringEvent event3 = new OutdoorGatheringEvent("Beach Party", "Enjoy the sun, sand, and surf with us", "Aug 7th", "12:00", address3, "Partly cloudy - bring sunscreen!");
    //Adding events to the list os events
    events.Add(event1);
    events.Add(event2);
    events.Add(event3);

    foreach (Event plannedEvent in events)
{
    Console.WriteLine("=============================");
    Console.WriteLine("STANDARD DETAILS:");
    Console.WriteLine("-----------------------------");
    plannedEvent.displayStandardDetails();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("FULL DETAILS:");
    Console.WriteLine("-----------------------------");
    plannedEvent.displayFullDetails();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("SHORT DESCRIPTION:");
    Console.WriteLine("-----------------------------");
    plannedEvent.displayShortDescription();
    Console.WriteLine("=============================");
}

  }
}
