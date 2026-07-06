using System;
using System.Collections.Generic;

public static class DataLoader
{
    public static void LoadData(Dictionary<string, ArcadeCard> cards)
    {
        cards.Clear();

        cards.Add("1001", new ArcadeCard
        {
            CashValue = 25.00,
            Credits = 100,
            Tickets = 250,
            Timeplay = "30 Minutes",
            Privileges = new List<string> { "VIP Access", "Birthday Bonus" }
        });

        cards.Add("1002", new ArcadeCard
        {
            CashValue = 10.00,
            Credits = 50,
            Tickets = 100,
            Timeplay = "None",
            Privileges = new List<string> { "Free Drink" }
        });

        cards.Add("1003", new ArcadeCard
        {
            CashValue = 40.00,
            Credits = 200,
            Tickets = 500,
            Timeplay = "60 Minutes",
            Privileges = new List<string> { "Unlimited Play" }
        });

        Console.WriteLine("Sample arcade cards loaded successfully.");
    }
}