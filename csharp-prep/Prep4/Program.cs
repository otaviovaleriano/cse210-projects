using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int input = -1;     
        while (input != 0)
        {
            Console.Write("Please enter a number or 0 to end: ");
            string numberEntered = Console.ReadLine();
            input = int.Parse(numberEntered);

            if (input != 0)
            {
                numbers.Add(input);

            }
        }

        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The Sum is: {total}");
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The Largest Number is: {largestNumber}");
        // double average = numbers.AsQueryable().Average();
        // int largestNumber = numbers.AsQueryable().Max();
        // Console.Write($"The Sum is: {total}");
        // Console.Write($"The Average is: {average}");
        // Console.Write($"The Largest Number is: {largestNumber}");
    }
}