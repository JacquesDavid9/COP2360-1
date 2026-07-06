using System;
using System.Collections.Generic;

public static class ReportEngine
{
    // Display using Keys
    public static void DisplayUsingKeys(Dictionary<string, ArcadeCard> cards)
    {
        Console.WriteLine("\n=== Display Using Keys ===");

        foreach (string key in cards.Keys)
        {
            ArcadeCard card = cards[key];

            Console.WriteLine($"Card Number: {key}");
            Console.WriteLine($"Cash Value: ${card.CashValue}");
            Console.WriteLine($"Credits: {card.Credits}");
            Console.WriteLine($"Tickets: {card.Tickets}");
            Console.WriteLine($"Timeplay: {card.Timeplay}");

            Console.Write("Privileges: ");
            foreach (string privilege in card.Privileges)
            {
                Console.Write(privilege + " ");
            }

            Console.WriteLine("\n");
        }
    }

    // Display using Values
    public static void DisplayUsingValues(Dictionary<string, ArcadeCard> cards)
    {
        Console.WriteLine("\n=== Display Using Values ===");

        foreach (ArcadeCard card in cards.Values)
        {
            Console.WriteLine($"Cash Value: ${card.CashValue}");
            Console.WriteLine($"Credits: {card.Credits}");
            Console.WriteLine($"Tickets: {card.Tickets}");
            Console.WriteLine($"Timeplay: {card.Timeplay}");

            Console.Write("Privileges: ");
            foreach (string privilege in card.Privileges)
            {
                Console.Write(privilege + " ");
            }

            Console.WriteLine("\n");
        }
    }

    // Display using KeyValuePairs
    public static void DisplayUsingKeyValuePairs(Dictionary<string, ArcadeCard> cards)
    {
        Console.WriteLine("\n=== Display Using KeyValuePairs ===");

        foreach (KeyValuePair<string, ArcadeCard> entry in cards)
        {
            Console.WriteLine($"Card Number: {entry.Key}");
            Console.WriteLine($"Cash Value: ${entry.Value.CashValue}");
            Console.WriteLine($"Credits: {entry.Value.Credits}");
            Console.WriteLine($"Tickets: {entry.Value.Tickets}");
            Console.WriteLine($"Timeplay: {entry.Value.Timeplay}");

            Console.Write("Privileges: ");
            foreach (string privilege in entry.Value.Privileges)
            {
                Console.Write(privilege + " ");
            }

            Console.WriteLine("\n");
        }
    }
}