using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._company = "Google";
       job1._startYear = 2000;
       job1._endYear = 2010;
       
       Job job2 = new Job();
       job2._jobTitle = "Web Developer";
       job2._company = "Reddit";
       job2._startYear = 2021;
       job2._endYear = 2023;

       Resume myResume = new Resume();
       myResume._name = "Otavio Silva";
       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);
       
       myResume.Display();
    }

}