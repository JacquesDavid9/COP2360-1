using System;
using System.Collections.Generic;
using System.Linq;

public class SortingService
{
    public static void SortCards(Dictionary<string, ArcadeCard> cards)
    {
        if (cards.Count == 0)
        {
            Console.WriteLine("No cards available to sort.\n");
            return;
        }

        Console.WriteLine("\nSorted Card List:");

        List<string> sortedKeys = cards.Keys.ToList();
        sortedKeys.Sort();

        foreach (string cardNumber in sortedKeys)
        {
            ArcadeCard card = cards[cardNumber];

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Card Number: {cardNumber}");
            Console.WriteLine($"Cash Value: ${card.CashValue:F2}");
            Console.WriteLine($"Credits: {card.Credits}");
            Console.WriteLine($"Tickets: {card.Tickets}");
            Console.WriteLine($"Timeplay: {card.Timeplay}");

            if (card.Privileges.Count > 0)
            {
                Console.WriteLine("Privileges: " + string.Join(", ", card.Privileges));
            }
            else
            {
                Console.WriteLine("Privileges: None");
            }
        }

        Console.WriteLine("--------------------------\n");
    }
}
