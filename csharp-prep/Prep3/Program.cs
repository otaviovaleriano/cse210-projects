using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        // Console.WriteLine($" This is your number: {number} ");

        bool guessed = false;
        int turns = 0;
        while (guessed == false)
        {
            Console.Write("Please enter your guess: ");
            int answer = int.Parse(Console.ReadLine());
            turns += 1;

            if (answer > number) 
            {
                Console.WriteLine("lower");
            }
            else if (answer < number)
            {
                Console.WriteLine("higher");
            }
            else 
            {
                Console.WriteLine("Correct!!! Great Job");
            // Console.WriteLine($"They guessed {answer}");
                guessed = true;                
            }
        }
        Console.WriteLine($"It took you {turns} turns to guess the righ number!");

    }
}