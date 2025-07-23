using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        myJournal.LoadJournal();
        Menu myMenu = new Menu();
        int userChoice = 0;

        do
        {
            userChoice = myMenu.GetMenuSelection();
            switch (userChoice)
            {
                case 1:
                    myJournal.WriteNewEntryWithoutPrompt();
                    break;
                case 2:
                    myJournal.WriteNewEntryWithPrompt();
                    break;
                case 3:
                    myJournal.DisplayJournal();
                    break;
                case 4:
                    myJournal.SaveJournal();
                    Console.WriteLine("t4esting case 4");
                    break;
                case 5:
                    myJournal.LoadJournal();
                    Console.WriteLine("t4esting case 5");
                    break;
                case 6:
                    if (myJournal._journalSaved)
                    {
                        Console.WriteLine("Exiting the application. Goodbye!");
                    }
                    else
                    {
                        Console.Write("You have unsaved changes. Would you like to save your journal before exiting? (y/n) ");
                        string response = Console.ReadLine();
                        if (response != "n")
                        {
                            userChoice = 0; // Reset choice to keep the menu open
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        } while (userChoice != 6);


    }// End of Main method
}


