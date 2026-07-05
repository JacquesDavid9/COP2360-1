using System.Collections.Generic;
 
public class ArcadeCard
{
    public double CashValue { get; set; } = 0.0;
    public int Credits { get; set; } = 0;
    public int Tickets { get; set; } = 0;
    public string Timeplay { get; set; } = "None";
    public List<string> Privileges { get; set; } = new List<string>();
}
