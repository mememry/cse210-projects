using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment currentMathAssignment = new MathAssignment("Melanie", "Basic Arithmetic", "Division", "29-35, 40-58");

        string printString = currentMathAssignment.GetSummary() + currentMathAssignment.GetHomeworkList();
        Console.WriteLine(printString);

        WritingAssignment currentWritingAssignment = new WritingAssignment("Melanie", "Basic Arithmetic", "The Use of Arithmetic in Literature");
        printString = currentWritingAssignment.GetWritingInformation();
        Console.WriteLine(printString);

    }
}