using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string userName = "";
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber = 0;

        Console.Write("Please enter your favorite integer: ");
        string input = Console.ReadLine();
        userNumber = int.Parse(input);
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"The square of {name}'s favorite integer is {number}.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squareNumber);

    }
}