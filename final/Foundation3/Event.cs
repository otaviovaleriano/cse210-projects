public class Event
{
  private string _title;
  private string _description;
  private string _date;
  private string _time;
  private Address _address = new Address();

  public Event(string title, string description, string date, string time, Address address)
  {
    _title = title;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
  }

  public void displayStandardDetails()
  {
    Console.WriteLine($"Title: {_title}\nDescription: {_description}\nOn {_date} at {_time}hrs\n{_address.displayAddress()}");
  }

  public virtual void displayFullDetails()
  {
    displayFullDetails();
  }

  public void displayShortDescription()
  {
    Console.WriteLine($"\"{_title}\" - {_description}. On {_date}");
  }


}