using static SplashKitSDK.SplashKit;

WriteLine("Let's make this more interesting!");

int minValue, maxValue;

// Loop until a valid range is provided
do
{
    // Get user input for the range
    WriteLine("Please enter the minimum number:");
    minValue = Convert.ToInt32(ReadLine());

    WriteLine("Please enter the maximum number:");
    maxValue = Convert.ToInt32(ReadLine());

    // Check if min is smaller than max
    if (minValue >= maxValue)
    {
        WriteLine("Oops! The minimum value should be less than the maximum value. Let's re-enter both values.");
    }
} while (minValue >= maxValue); // Continue asking until valid

WriteLine($"Get ready to generate a random number between {minValue} and {maxValue}...");
WriteLine("Drum roll please...");

// Generate a random number in the specified range
int randomNumber = Rnd(minValue, maxValue);

WriteLine($"Your lucky number is: {randomNumber}!");
WriteLine("How does it feel? Want to try again?");