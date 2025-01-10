using static SplashKitSDK.SplashKit;

WriteLine("Check the ASCII value of a character.");
WriteLine("Press 'q' to quit, or type any character to see its ASCII value.");

while (true)
{
    Write("Enter a character: ");
    char input = ReadChar(); // Read a single character input

    if (input == 'q') // Quit if 'q' is pressed
    {
        WriteLine("You pressed 'q'. Exiting the program. Goodbye!");
        break;
    }
    else
    {
        // Display the ASCII value of the character
        WriteLine($"You pressed '{input}' (ASCII: {(int)input}).");
    }
}