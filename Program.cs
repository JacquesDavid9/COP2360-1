using System;
using System.Collections.Generic;
 
class Program
{
    // The single shared dictionary used across the whole program.
    // Key   = card number (string)
    // Value = ArcadeCard object holding CashValue, Credits, Tickets, etc.
    static Dictionary<string, ArcadeCard> cards = new Dictionary<string, ArcadeCard>();
 
    static void Main()
    {
        // Member 2 (Data Loader) will pre populate this dictionary with starting test records here.
        DataLoader.PopulateCards(cards);
 
        bool running = true;
 
        while (running)
        {
            PrintMenu();
 
            string input = Console.ReadLine();
 
            // TryParse prevents the program from crashing if the user types something that isn't a number.
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number from the menu.\n");
                continue;
            }
 
            switch (choice)
            {
                case 1:
                    // Task 1.2 - Member 2: Display dictionary contents
                    ReportEngine.DisplayReport(cards);
                    break;
 
                case 2:
                    // Task 1.4 - Member 3: Register a new card
                    AccountManager.RegisterCard(cards);
                    break;
 
                case 3:
                    // Task 1.3 - Member 3: Remove an existing card
                    AccountManager.RemoveCard(cards);
                    break;
 
                case 4:
                    // Task 1.5 - Member 4: Update an existing card's data
                    TransactionEngine.UpdateCard(cards);
                    break;
 
                case 5:
                    // Task 1.6 - Member 5: Sort and display keys
                    SortingService.DisplaySortedKeys(cards);
                    break;
 
                case 6:
                    running = false;
                    Console.WriteLine("Exiting Arcade Smart Card System. Goodbye!");
                    break;
 
                default:
                    // Handles any number that doesn't match a valid menu option
                    Console.WriteLine("That option doesn't exist. Please choose a valid number.\n");
                    break;
            }
        }
    }
 
    // Keeps the menu display separate from the routing logic for readability.
    static void PrintMenu()
    {
        Console.WriteLine("========= Arcade Smart Card System =========");
        Console.WriteLine("1. Display all card accounts (Report)");
        Console.WriteLine("2. Register a new card");
        Console.WriteLine("3. Remove a card");
        Console.WriteLine("4. Update card balance / credits / tickets / privileges");
        Console.WriteLine("5. Display sorted card numbers");
        Console.WriteLine("6. Exit");
        Console.Write("Choose an option: ");
    }
}
