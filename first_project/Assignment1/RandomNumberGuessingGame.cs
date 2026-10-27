using System;

class RandomNumberGame
{

    static void PlayGame()
    {

        Random random = new Random();
        int randomNumber = random.Next(1, 101);

        int attempt = 0;
        int maxAttempt = 5;
        int guess;
        int score;
        bool isCorrect = false;

        Console.WriteLine("You have only 5 guesses");
        Console.WriteLine("Enter number from only 1 to 100");
        while (attempt < maxAttempt)
        {

            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess >= 1 && guess <= 100)
            {
                attempt++;
                if (guess == randomNumber)
                {
                    isCorrect = true;
                    Console.WriteLine($"You have guessed the number {guess}");
                    break;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Try lower Number");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Try Higher Number");
                }

                Console.WriteLine($"Attempts remaining: {maxAttempt - attempt}");

            }
            else
            {
                Console.WriteLine("Enter a number from 1 to 100");
            }
        }

        if (isCorrect)
        {
            score = (maxAttempt - attempt + 1) * 20;
            Console.WriteLine("Congratulations! You won!");
        }
        else
        {
            score = 0;
            Console.WriteLine("Sorry, you didn't guess the number.");
            Console.WriteLine($"The correct number was {randomNumber}.");
        }

        Console.WriteLine($"You took {attempt} attempts to answer.");
        Console.WriteLine($"Your score is {score}");

    }


    static void Main(string[] args)
    {
        string play;

        while (true)
        {
            Console.Write("Do you want to play? (y/n): ");
            play = Console.ReadLine().Trim().ToLower();

            if (play == "y")
            {
                PlayGame();
            }
            else if (play == "n")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter y or n.");
            }
        }
    }


}