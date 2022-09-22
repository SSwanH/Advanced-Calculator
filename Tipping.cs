using System;



namespace CodingChallenge;

public class Tipping
{
    private static string tipAgain;
    
    
    public static void TipCalculation(double firstNumber)

    {
        Console.WriteLine("Please select a tip percentage you'd like to calculate.");
        Console.WriteLine("Would you like to tip 18%, 20%, or 25%?");
        string? tipPercentage = Console.ReadLine();
        bool cont = true;
        do
        {
            switch (tipPercentage)
            {
                case "18%":
                    var smallTip = firstNumber * .18;
                    Console.WriteLine($"An 18% tip on your {firstNumber} total would come out to {smallTip}");
                    cont = true;
                    break;
                case "20%":
                    var medTip = firstNumber * .2;
                    Console.WriteLine($"A 20% tip on your {firstNumber} total would come out to {medTip}");
                    cont = true;
                    break;
                case "25%":
                    var bigTip = firstNumber * .25;
                    Console.WriteLine($"An 25% tip on your {firstNumber} total would come out to {bigTip}");
                    cont = true;
                    break;
                default:
                    Console.WriteLine("Incorrect entry - please select 18%, 20%, or 25%");
                    tipPercentage = Console.ReadLine();
                    cont = false;
                    break;
            }
        } while (cont == false);
        // } while (tipPercentage == "18%" ||
        //          tipPercentage == "20%" ||
        //          tipPercentage == "25%");

        // Console.WriteLine("Would you like to Continue(Y), or Exit to Menu(M)?");
        // Console.WriteLine("You may press any other key to exit the program.");
        // tipAgain = Console.ReadLine().ToLower();
    }

    

}