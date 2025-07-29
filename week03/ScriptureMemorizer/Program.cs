using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string choice = "";

        do
        {
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Press 'q' to quit, press any other key to continue.");
            choice = Console.ReadLine();
            //Console.Clear();
            scripture.HideWords();

        } while (choice != "q");
        scripture.DisplayWholeScripture();

    }
}