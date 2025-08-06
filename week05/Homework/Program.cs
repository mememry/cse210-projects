using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment currentAssignment = new MathAssignment("Melanie", "Basic Arithmetic", "Division", "29-35, 40-58");

        string printString = currentAssignment.GetSummary() + currentAssignment.GetHomeworkList();
        Console.WriteLine(printString);

        Console.WriteLine("Hello World! This is the Homework Project.");
    }
}