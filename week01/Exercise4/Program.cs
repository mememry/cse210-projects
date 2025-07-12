using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string inputNumber;
        int newNumber;
        int listCount = 0;
        int sum = 0;
        int average = 0;
        int max = 0;
        int smallest = 10000000;

        Console.WriteLine("Please enter a list of positive and negative numbers. Enter 0 to end.");

        do
        {
            Console.Write("Enter number: ");
            inputNumber = Console.ReadLine();
            newNumber = int.Parse(inputNumber);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }
        average = sum / numbers.Count;
        numbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The number list in order is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}