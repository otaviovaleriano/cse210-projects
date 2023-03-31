class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("__________________");
    Console.WriteLine("                  ");
    Console.WriteLine("EXERCISE TRACKING");
    Console.WriteLine("__________________");
    Console.WriteLine("                  ");
    List<Activity> activities = new List<Activity>();
    //Creating the three types of activities
    RunningActivity runningActivity = new RunningActivity("Running", "01 Jan 2023", 40, 5.0);
    CyclingActivity cyclingActivity = new CyclingActivity("Cycling", "26 May 2022", 70, 9.5);
    SwimmingActivity swimmingActivity = new SwimmingActivity("Swimming", "15 Dec 2022", 35, 50);
    //Adding the activities to the list of Activities.
    activities.Add(runningActivity);
    activities.Add(cyclingActivity);
    activities.Add(swimmingActivity);

    foreach (Activity activity in activities)
    {
      activity.DisplaySummary();
      Console.WriteLine("                  ");
      Console.WriteLine("___________________");
      Console.WriteLine("                  ");


    }
  }
}
