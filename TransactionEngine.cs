using System;
using System.Collections.Generic;

public class TransactionEngine
{
    public static void UpdateCard(Dictionary<string, ArcadeCard> cards)
    {
        Console.Write("Enter card number to update: ");
        string cardNumber = Console.ReadLine();

        if (!cards.ContainsKey(cardNumber))
        {
            Console.WriteLine("Card not found.\n");
            return;
        }

        ArcadeCard card = cards[cardNumber];

        Console.WriteLine("\nWhat would you like to update?");
        Console.WriteLine("1. Add cash value");
        Console.WriteLine("2. Add credits");
        Console.WriteLine("3. Add tickets");
        Console.WriteLine("4. Add privilege");
        Console.Write("Choose an option: ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Invalid option.\n");
            return;
        }

        switch (choice)
        {
            case 1:
                Console.Write("Enter cash amount to add: ");
                if (double.TryParse(Console.ReadLine(), out double cash))
                {
                    card.CashValue += cash;
                    Console.WriteLine("Cash value updated.\n");
                }
                else
                {
                    Console.WriteLine("Invalid cash amount.\n");
                }
                break;

            case 2:
                Console.Write("Enter credits to add: ");
                if (int.TryParse(Console.ReadLine(), out int credits))
                {
                    card.Credits += credits;
                    Console.WriteLine("Credits updated.\n");
                }
                else
                {
                    Console.WriteLine("Invalid credit amount.\n");
                }
                break;

            case 3:
                Console.Write("Enter tickets to add: ");
                if (int.TryParse(Console.ReadLine(), out int tickets))
                {
                    card.Tickets += tickets;
                    Console.WriteLine("Tickets updated.\n");
                }
                else
                {
                    Console.WriteLine("Invalid ticket amount.\n");
                }
                break;

            case 4:
                Console.Write("Enter privilege to add: ");
                string privilege = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(privilege))
                {
                    card.Privileges.Add(privilege);
                    Console.WriteLine("Privilege added.\n");
                }
                else
                {
                    Console.WriteLine("Privilege cannot be blank.\n");
                }
                break;

            default:
                Console.WriteLine("Invalid option.\n");
                break;
        }
    }
}
