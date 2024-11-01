using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the Number Guessing Game!");
WriteLine("I'm thinking of a number between 1 and 100...");

// Set a secret number
int secretNumber = 42;

int guess = -1;  // Initialise with an invalid guess

// Ask the user for their guess
while (guess != secretNumber)
{
    WriteLine("Please enter your guess:");
    string input = ReadLine();

    // Validate if the input is a valid integer
    if (IsInteger(input))
    {
        // Convert input string to integer
        guess = ConvertToInteger(input);

        // Check if the guess is correct
        if (guess == secretNumber)
        {
            WriteLine($"Congratulations! You've guessed the correct number: {guess}");
        }
        else if (guess < secretNumber)
        {
            WriteLine("Too low! Try again.");
        }
        else
        {
            WriteLine("Too high! Try again.");
        }
    }
    else
    {
        WriteLine("That's not a valid integer! Please enter a number.");
    }
}
