using System;



namespace CodingChallenge;

public class Tipping
{
    public static double GetBillNumber()
    {
        string? billNumberInput;
        bool billNumberIsDouble;
        double billAmount;
        Console.WriteLine("Please enter your bill amount:");
        Console.Write("$");
        billNumberInput = Console.ReadLine();
        billNumberIsDouble = Double.TryParse(billNumberInput, out billAmount);

        while (!billNumberIsDouble || billAmount < 0)
        {
            Console.WriteLine("Invalid entry. Please enter your bill amount:");
            Console.Write("$");
            billNumberInput = Console.ReadLine();
            billNumberIsDouble = Double.TryParse(billNumberInput, out billAmount);
        }
        return Math.Round(billAmount, 2);
    }

    public static void TipCalculation(double billAmount)
    {
        Console.WriteLine();
        Console.WriteLine("Please select a tip percentage you'd like to calculate.");
        Console.WriteLine("Would you like to tip 18%, 20%, or 25%?");
        string? tipPercentage = Console.ReadLine();
        Console.WriteLine();
        bool cont = true;
        do
        {
            switch (tipPercentage)
            {
                case "18%":
                    var smallTip = billAmount * .18;
                    Console.WriteLine($"An 18% tip on your ${billAmount} total would come out to ${Math.Round(smallTip, 2)}");
                    cont = true;
                    break;
                case "20%":
                    var medTip = billAmount * .2;
                    Console.WriteLine($"A 20% tip on your ${billAmount} total would come out to ${Math.Round(medTip, 2)}");
                    cont = true;
                    break;
                case "25%":
                    var bigTip = billAmount * .25;
                    Console.WriteLine($"An 25% tip on your ${billAmount} total would come out to ${Math.Round(bigTip, 2)}");
                    cont = true;
                    break;
                default:
                    Console.WriteLine("Incorrect entry - please select 18%, 20%, or 25%");
                    tipPercentage = Console.ReadLine();
                    cont = false;
                    break;
            }
        } while (cont == false);
    }

    

}