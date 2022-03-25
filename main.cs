// Cristiano
// ICS2O-Unit2-05-CSharp
// March 25 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        float hours;
        float hourlypay;
        Console.WriteLine("Enter hours worked:");
        hours = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter hourly pay:");
        hourlypay = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("You'll earn $" + ((hours * hourlypay) * (1 - 0.18)).ToString("0.00") + ", and the government will earn $" + ((hours * hourlypay) * 0.18).ToString("0.00") + ".");
        Console.WriteLine("\nFinished.");
    }
}
