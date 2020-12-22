using System;
using System.Linq;
namespace NoGuesserV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int guess = 0, noOfGuesses = 0, difficulty = 0, x = 0, y = 0, number = 0;
            string dif, canYouGuess = "My number is between {0} and {1}.";
            Console.WriteLine("Welcome to paradox#4005's number guesser!\nWhat difficulty would you like to select out of:\nEasy - 1, Medium - 2, Hard - 3 or Custom Range (4)");
            dif = Console.ReadLine();
            difficulty = Int32.Parse(dif);
            switch (difficulty) {
                case 1:
                    x = 1; y = 10;
                    Console.WriteLine(canYouGuess, x, y);
                    number = r.Next(x, y);
                    while (guess != number)
                    {
                        Console.WriteLine("Can you guess what it is?");
                        string input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        if (guess < number)
                        {
                            Console.WriteLine("The number is higher than your guess.");
                            noOfGuesses++;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("The number is lower than your guess.");
                            noOfGuesses++;
                        }

                    }
                    noOfGuesses++;
                    Console.WriteLine("The number was {0}, you took {1} tries!", number, noOfGuesses);
                    Console.ReadKey();
                    break;
                case 2:
                    x = 1; y = 50;
                    Console.WriteLine(canYouGuess, x, y);
                    number = r.Next(x, y);
                    while (guess != number)
                    {
                        Console.WriteLine("Can you guess what it is?");
                        string input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        if (guess < number)
                        {
                            Console.WriteLine("The number is higher than your guess.");
                            noOfGuesses++;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("The number is lower than your guess.");
                            noOfGuesses++;
                        }

                    }
                    noOfGuesses++;
                    Console.WriteLine("The number was {0}, you took {1} tries!", number, noOfGuesses);
                    Console.ReadKey();
                    break;
                case 3:
                    x = 1; y = 100;
                    Console.WriteLine(canYouGuess, x, y);
                    number = r.Next(x, y);
                    while (guess != number)
                    {
                        Console.WriteLine("Can you guess what it is?");
                        string input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        if (guess < number)
                        {
                            Console.WriteLine("The number is higher than your guess.");
                            noOfGuesses++;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("The number is lower than your guess.");
                            noOfGuesses++;
                        }

                    }
                    noOfGuesses++;
                    Console.WriteLine("The number was {0}, you took {1} tries!", number, noOfGuesses);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Enter a number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a second number: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (x > y)
                    {
                        number = r.Next(y, x);
                    } else if (x < y)
                    {
                        number = r.Next(x, y);
                    } else
                    {
                        number = r.Next(x, y);
                    }
                    Console.WriteLine(canYouGuess, x, y);

                    while (guess != number)
                    {
                        Console.WriteLine("Can you guess what it is?");
                        string input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        if (guess < number)
                        {
                            Console.WriteLine("The number is higher than your guess.");
                            noOfGuesses++;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("The number is lower than your guess.");
                            noOfGuesses++;
                        }

                    }
                    noOfGuesses++;
                    Console.WriteLine("The number was {0}, you took {1} tries!", number, noOfGuesses);
                    Console.ReadKey();
                    break;
                default:
                    Console.Beep();
                    break;
            }


        }
    }
}
