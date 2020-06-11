using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                /************************************
                 *  John Krise 9/30/19
                 *  
                 *  guessing game
                 * 
                 * a random number guessing game that has the user guess a 
                 * number between the given amount. will also tell them how many times it took to guess the number.
                 * 
                 * 
                 * 
                 ************************************/
                //const int MAX_NUMBER = 100; // allows highest possible guessing number

                Random random = new Random();
                int numberToGuess = random.Next(1,100);
                int userGuess = 0;
                int guesses = 0;

                       
                Console.WriteLine("Welcome to 'Guess the Number'");
            beginning: // start of code to loop if user wants to replay
                Console.WriteLine("Guess a number between 1 and 100 "/*{0}., MAX_NUMBER*/);
               
                while (userGuess != numberToGuess)
                {
                    guesses++;

                    Console.Write("Enter your guess: ");
                    int.TryParse(Console.ReadLine(), out userGuess);

                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("{0} is too high!", userGuess);
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("{0} is too low!", userGuess);
                    }
                    else
                    {
                        Console.WriteLine("{0} is right! Congratulations.", userGuess);
                        Console.WriteLine("you took {0} guess to get it right ", guesses);

                        Console.WriteLine("Would you like to try again ? (y / n)"); // prompts user if they want to play again

                        if (Console.ReadLine().ToLower() != "y")
                        { break; }
                        else
                        {
                            numberToGuess = random.Next(1, 100);
                            userGuess = 0;
                            goto beginning; }     
                    }
                }
            }
        }
    }
}


