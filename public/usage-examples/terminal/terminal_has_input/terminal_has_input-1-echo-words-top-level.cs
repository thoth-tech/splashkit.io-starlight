using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the Terminal Input Checker!");
WriteLine("Type something and press Enter to see it echoed back.");
WriteLine("Type 'exit' and press Enter to quit the program.");

string input;

do
{
    // Check if there's input waiting in the terminal
    if (TerminalHasInput())
    {
        // Read the input
        input = ReadLine();
        if (input != "exit")
        {
            WriteLine("You typed: " + input);
        }
    }
    else
    {
        input = string.Empty; // If no input, continue waiting
    }
} while (input != "exit");

WriteLine("Exiting the program...");