using System;
using System.Collections.Generic;

public static class AccountManager
{

    /// Prompts the user for a new unique card number and initializes it with empty tracking buckets.
    
    public static void AddNewCard(Dictionary<int, ArcadeCard> arcadeSystem)
    {
        Console.WriteLine("\n--- Register New Arcade Card ---");
        Console.Write("Enter a new 6-digit Card Number to register: ");

        // Safely parse the user input to an integer to protect against crashes
        if (!int.TryParse(Console.ReadLine(), out int newCardNumber))
        {
            Console.WriteLine("Error: Invalid input. Card numbers must be numerical.");
            return;
        }

        // Check if the key already exists using a direct dictionary lookup (no loops!)
        if (arcadeSystem.ContainsKey(newCardNumber))
        {
            Console.WriteLine($"Registration Failed: Card #{newCardNumber} already exists in the system.");
        }
        else
        {
            // Instantly create the new key and assign it a fresh, blank ArcadeCard object
            arcadeSystem.Add(newCardNumber, new ArcadeCard());
            Console.WriteLine($"Success! Card #{newCardNumber} has been registered with empty buckets.");
        }
    }


    /// Prompts the user for a card number to delete (e.g., if a guest loses their card) and removes it from memory.
    
    public static void RemoveCard(Dictionary<int, ArcadeCard> arcadeSystem)
    {
        Console.WriteLine("\n--- Deactivate / Remove Card ---");
        Console.Write("Enter the Card Number you wish to remove: ");

        if (!int.TryParse(Console.ReadLine(), out int cardToRemove))
        {
            Console.WriteLine("Error: Invalid input. Card numbers must be numerical.");
            return;
        }

        // Check if the key exists before attempting deletion
        if (arcadeSystem.ContainsKey(cardToRemove))
        {
            // Remove the key and its associated value object from the dictionary entirely
            arcadeSystem.Remove(cardToRemove);
            Console.WriteLine($"Success: Card #{cardToRemove} has been deleted from the database.");
        }
        else
        {
            Console.WriteLine($"Deletion Failed: Card #{cardToRemove} could not be found.");
        }
    }
}
