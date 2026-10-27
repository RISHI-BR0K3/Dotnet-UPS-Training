using System;

class SecretCodeBreaker
{
    static void PlayGame()
    {
        Random random = new Random();

        int secretCode = random.Next(1000, 10000);
        int maxAttempts = 10;
        int attempts = 0;
        int score = 0;
        bool isCorrect = false;

        Console.WriteLine();
        Console.WriteLine("    Secret Code Breaker    ");
        Console.WriteLine("find the 4-digit secret code");
        Console.WriteLine("You have only 10 attempts.");

        while (attempts < maxAttempts)
        {
            Console.WriteLine();
            Console.Write("Enter your 4-digit guess: ");
            string guess = Console.ReadLine();

            if (guess.Length != 4)
            {
                Console.WriteLine("Please enter a 4-digit number.");
                continue;
            }

            attempts++;

            string secret = secretCode.ToString();
            int correctDigits = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == secret[i])
                {
                    correctDigits++;
                }
            }

            if (correctDigits == 4)
            {
                isCorrect = true;
                score = (maxAttempts - attempts + 1) * 10;

                Console.WriteLine("Code is correct");
                Console.WriteLine($"Secret code: {secretCode}");
                Console.WriteLine($"Attempts used: {attempts}");
                Console.WriteLine($"Your score: {score}");
                break;
            }
            else
            {
                Console.WriteLine($"Correct digits in correct positions: {correctDigits}");
                Console.WriteLine($"Attempts remaining: {maxAttempts - attempts}");
            }
        }

        if (!isCorrect)
        {
            Console.WriteLine();
            Console.WriteLine("Game over you didnt crack the code");
            Console.WriteLine($"The secret code was: {secretCode}");
            Console.WriteLine("Your score: 0");
        }
    }

    static void Main()
    {
        string choice;

        do
        {
            PlayGame();

            Console.WriteLine();
            Console.Write("Do you want to try a new code? (y/n): ");
            choice = Console.ReadLine().Trim().ToLower();

        } while (choice == "y");

        Console.WriteLine("Thanks for playing");
    }
}
