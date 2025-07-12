using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage (0-100): ");
        string input = Console.ReadLine();
        float gradePercentage = float.Parse(input);
        string letter;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A")
        {
            Console.WriteLine($"Congratulations! You received an {letter}. You passed the course with flying colors!");
        }
        else if (gradePercentage >= 70)
            {
                Console.WriteLine($"You received a {letter}. Congratulations on passing the course!");
            }
        else
            {
                Console.WriteLine($"You received a {letter}. This iks not a passing grade. Please see me for suggestions on how to pass the course next time.");
            }
    }
}