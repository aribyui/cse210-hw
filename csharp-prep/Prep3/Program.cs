using System;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {     

        /* 
        1. Start by asking the user for the magic number. (In future steps, we will change this to have the 
        computer generate a random number, but to get started, we'll just let the user decide what it is.) 
        Ask the user for a guess.
        Using an if statement, determine if the user needs to guess higher or lower next time, or tell them if they 
        guessed it.         
        At this point, you won't have any loops.
        */
         
        // Console.Write("What is the magic number? ");
        // string answer = Console.ReadLine();
        // int number = int.Parse(answer);

        // if (number < 47) 
        // {
        //     Console.Write("Higher");
        // }
        // else if (number > 47)
        // {
        //     Console.Write("Lower");
        // }
        // else
        // {
        //     Console.Write("You guessed it!");;
        // }        
        
        /*
        2. Add a loop that keeps looping as long as the guess does not match the magic number.
        At this point, the user should be able to keep playing until they get the correct answer.
        */
        // Console.Write("What is the magic number? ");
        // string answer1 = Console.ReadLine();
        // int magicNumber = int.Parse(answer1); 

        // // the variable 'guessNumber' is initialized to be able to use the while loop
        // int guessNumber = 0;

        // while (guessNumber != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     string answer2 = Console.ReadLine();
        //     guessNumber = int.Parse(answer2);

        //     if (guessNumber < magicNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guessNumber > magicNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }

        /*
        3. Instead of having the user supply the magic number, generate a random number from 1 to 100.
        Play the game and make sure it works!
        */
        // Random random = new Random();
        // int randomNumber = random.Next(1, 100);

        // int guessNumber = 0;

        // while (guessNumber != randomNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     string answer = Console.ReadLine();
        //     guessNumber = int.Parse(answer);            


        //     if (guessNumber < randomNumber)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (guessNumber > randomNumber)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it!");
        //     }
        // }

        /*
        Stretch Challenge
        1. Keep track of how many guesses the user has made and inform them of it at the end of the game.
        2. After the game is over, ask the user if they want to play again. Then, loop back and play the whole game 
        again and continue this loop as long as they keep saying "yes".
        */       
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guessNumber = 0;
            int counter = 0;

            while (guessNumber != randomNumber)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guessNumber = int.Parse(answer);

                counter++;

                if (guessNumber < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Attemps: {counter}");                    
                }                
            }
            Console.Write("Do you want to play again? ");
            keepPlaying = Console.ReadLine();
        } 
        Console.WriteLine("Thanks for playing!");  
    }
}