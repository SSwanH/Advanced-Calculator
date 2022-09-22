using System;
using System.ComponentModel.Design;
using CodingChallenge;
using static System.Collections.Specialized.BitVector32;

namespace CodingChallenge;


internal class Program
{
    private static void Main(string[] args)
    {
        string? keepGoing;
        string? tipOrCalc;
        do
        {
            //Intro
            Console.WriteLine(
                "Hello! This is a simple calculator that will allow you to add (+), subtract (-), multiply (*), and divide (/) two numbers, or you can choose to calculate a tip!");
            Console.WriteLine("Please choose 1 for tipping calculator, or choose 2 for Simple Calculator");
            tipOrCalc = (Console.ReadLine());
            while (tipOrCalc != "1" &&
                   tipOrCalc != "2")
            {
                Console.WriteLine(
                    "Incorrect action selected - please select Tipping Calculator (1) or Simple Calculator (2)");
                tipOrCalc = Console.ReadLine();
            }

            if (tipOrCalc == "1")
            {
                Tipping.TipCalculation(Tipping.GetBillNumber());
            }
            else if (tipOrCalc == "2")
            {
                Console.WriteLine("Please enter your first number");

                Console.WriteLine();

                //Get First Number
                var firstNumber = GetFirstNumber();
                Console.WriteLine();

                //Choose Operator
                Console.WriteLine("Enter the action to be performed");
                Console.WriteLine("Press + add");
                Console.WriteLine("Press - to Subtract");
                Console.WriteLine("Press * to Multiply");
                Console.WriteLine("Press / to Divide");

                string? desiredAction = (Console.ReadLine());
                while (desiredAction != "+" &&
                       desiredAction != "-" &&
                       desiredAction != "*" &&
                       desiredAction != "/")
                {
                    Console.WriteLine("Incorrect action selected - action must be: +, -, *, /");
                    desiredAction = Console.ReadLine();
                }
                // if (desiredAction == "$")
                // {
                //     Tipping.TipCalculation(firstNumber);
                // }
                Console.WriteLine();
                Console.WriteLine();

                    //Get Second Number
                    string? secondNumberInput;
                    bool secondNumberIsDouble;
                    var secondNumber = GetSecondNumber();

                    //If divide by zero
                    while (desiredAction == "/" && secondNumber == 0)
                    {
                        Console.WriteLine(
                            "Invalid entry - cannot divide by 0. Please enter a different second number:");
                        secondNumberInput = Console.ReadLine();
                        secondNumberIsDouble = Double.TryParse(secondNumberInput, out secondNumber);
                    }

                    //Operations
                    switch (desiredAction)
                    {
                        case "+":
                            var addition = firstNumber + secondNumber;
                            Console.WriteLine($"Solution {firstNumber} + {secondNumber} = {addition}");
                            break;

                        case "-":
                            var subtraction = firstNumber - secondNumber;
                            Console.WriteLine($"Solution {firstNumber} - {secondNumber} = {subtraction}");
                            break;

                        case "*":
                            var multiplication = firstNumber * secondNumber;
                            Console.WriteLine($"Solution {firstNumber} * {secondNumber} = {multiplication}");
                            break;

                        case "/":
                            var division = firstNumber / secondNumber;
                            Division(firstNumber, secondNumber);
                            break;

                        default:
                            Console.WriteLine("Incorrect action selected - action must be: +, -, *, /");
                            break;
                    }
            }

            //Continue?
                Console.WriteLine("To continue, press Y, to exit press any other key");
                keepGoing = Console.ReadLine().ToLower();
        } while (keepGoing == "y");

        //Exit
                Console.WriteLine("kthxbye.");

            }

    private static double GetSecondNumber()
    {
        Console.WriteLine("Please enter your second number");
        Console.WriteLine();
        string? secondNumberInput;
        bool secondNumberIsDouble;
        double secondNumber;

        secondNumberInput = Console.ReadLine();
        secondNumberIsDouble = Double.TryParse(secondNumberInput, out secondNumber);

        while (!secondNumberIsDouble)
        {
            Console.WriteLine("Invalid entry. Please enter a number:");
            secondNumberInput = Console.ReadLine();
            secondNumberIsDouble = Double.TryParse(secondNumberInput, out secondNumber);
        }

        return secondNumber;
    }

    private static double GetFirstNumber()
            {
                string? firstNumberInput;
                bool firstNumberIsDouble;
                double firstNumber;

                firstNumberInput = Console.ReadLine();
                firstNumberIsDouble = Double.TryParse(firstNumberInput, out firstNumber);

                while (!firstNumberIsDouble)
                {
                    Console.WriteLine("Invalid entry. Please enter a number");
                    firstNumberInput = Console.ReadLine();
                    firstNumberIsDouble = Double.TryParse(firstNumberInput, out firstNumber);
                }

                return firstNumber;
            }

            private static void Division(double firstNumber, double secondNumber)
            {
                var result = (firstNumber / secondNumber);
                Console.WriteLine($"Solution {firstNumber} / {secondNumber} = {result}");

            }
        }
    
