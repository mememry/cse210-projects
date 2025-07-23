/*
    The Menu class provides a text based menu for the user to interact with the journal application.
    */
    public class Menu
    {
        public int _menuSelection = 0;

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Journal Application!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry without a prompt");
            Console.WriteLine("2. Write a new entry with a random prompt");
            Console.WriteLine("3. Display all entries");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Load journal");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
        

        }

        public int GetMenuSelection()
        {
            DisplayMenu();

            string input = Console.ReadLine();
            _menuSelection = int.Parse(input);

            if (_menuSelection < 1 || _menuSelection > 6)
            {
                Console.WriteLine("Invalid selection. Please try again.");
                GetMenuSelection();
            }

            return _menuSelection;
        }
    }// End of Menu class


   