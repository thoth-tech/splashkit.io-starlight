using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the Terminal Input Checker!");
WriteLine("Type something and press Enter to see it echoed back.");
WriteLine("Type 'exit' and press Enter to quit the program.");

while (true)
{
    // Check if there's input waiting in the terminal
    if (TerminalHasInput())
    {
        // Read and echo the input
        string input = ReadLine();
        if (input == "exit")
        {
            WriteLine("Exiting the program...");
            break;
        }
        WriteLine("You typed: " + input);
    }
}