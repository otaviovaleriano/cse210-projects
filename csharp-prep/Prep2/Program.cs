using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" Inform your grade in %: ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
            else if (grade >= 80 ) 
            {
                letter = "B";
            }
            else if (grade >= 70 ) {
                letter = "C";
            }
            else if (grade >= 60 ) {
                letter = "D";
            }
            else if (grade >= 50)
            {
            letter = "F";
            }
        
        Console.WriteLine($"Your Grade is: {letter} !!");

        if (grade > 70) {
            Console.Write("Congratulations, You Passed!!");
        }
        else {
            Console.Write("You Failed - Good Luck Next Time!!");
        }

    }
}