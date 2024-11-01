using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Welcome to the Number Guessing Game!");
            SplashKit.WriteLine("I'm thinking of a number between 1 and 100...");

            // Set a secret number
            int secretNumber = 42;

            int guess = -1;  // Initialise with an invalid guess

            // Ask the user for their guess
            while (guess != secretNumber)
            {
               SplashKit. WriteLine("Please enter your guess:");
                string input = SplashKit.ReadLine();

                // Validate if the input is a valid integer
                if (SplashKit.IsInteger(input))
                {
                    // Convert input string to integer
                    guess = SplashKit.ConvertToInteger(input);

                    // Check if the guess is correct
                    if (guess == secretNumber)
                    {
                        SplashKit.WriteLine($"Congratulations! You've guessed the correct number: {guess}");
                    }
                    else if (guess < secretNumber)
                    {
                        SplashKit.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        SplashKit.WriteLine("Too high! Try again.");
                    }
                }
                else
                {
                    SplashKit.WriteLine("That's not a valid integer! Please enter a number.");
                }
            }

        }
    }
}