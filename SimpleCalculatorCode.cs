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
        do
        {
            //Intro
            Console.WriteLine(
                "Hello! This is a simple calculator that will allow you to add (+), subtract (-), multiply (*), and divide (/) two numbers, or you can choose to calculate a tip!");
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
            Console.WriteLine("Press $ to calculate a 18%, 20%, or 25% tip");


            string? desiredAction = (Console.ReadLine());

            if (desiredAction == "$")
            {
                Tipping.TipCalculation(firstNumber);
                //Tipping options
                //Validate input
                //Do calculation here?
            }
            else if (desiredAction == "+" ||
                     desiredAction == "-" ||
                     desiredAction == "*" ||
                     desiredAction == "/")

            {
                Console.WriteLine();
                Console.WriteLine();

                //Get Second Number
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

                //If divide by zero
                while (desiredAction == "/" && secondNumber == 0)
                {
                    Console.WriteLine(
                        "Invalid entry - cannot divide by 0. Please enter a different second number:");
                    secondNumberInput = Console.ReadLine();
                    secondNumberIsDouble = Double.TryParse(secondNumberInput, out secondNumber);
                }

                //Operations
                var addition = firstNumber + secondNumber;
                var subtraction = firstNumber - secondNumber;
                var multiplication = firstNumber * secondNumber;
                var division = firstNumber / secondNumber;


                switch (desiredAction)
                {
                    case "+":
                    {
                        Console.WriteLine($"Solution {firstNumber} + {secondNumber} = {addition}");
                        break;
                    }
                    case "-":
                    {
                        Console.WriteLine($"Solution {firstNumber} - {secondNumber} = {subtraction}");
                        break;
                    }
                    case "*":
                    {
                        Console.WriteLine($"Solution {firstNumber} * {secondNumber} = {multiplication}");
                        break;
                    }
                    case "/":
                    {
                        Division(firstNumber, secondNumber);
                        break;
                    }

                    default:
                        Console.WriteLine("Incorrect action selected - action must be: +, -, *, /");
                        break;
                }



            
            }
            else
            {
                Console.WriteLine("Incorrect entry - please select +, -, *, / 0000000000000000");
                while
                {
                    
                }
            
                desiredAction = Console.ReadLine();
            }
            //Continue?
            Console.WriteLine("To continue, press Y, to exit press any other key");
            keepGoing = Console.ReadLine().ToLower();
            
        }
        while (keepGoing == "y") ;

                //Exit
                Console.WriteLine("kthxbye.");

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
    
