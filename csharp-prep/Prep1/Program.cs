using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Inform your First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Inform your Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Your name is " + lastName + ", " + firstName + " " + lastName);
        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}