// Usage Example for: https://splashkit.io/api/text/#is-integer
// Goal: I am reading text and I am printing whether each line is an integer.
// Why: I am showing how to use IsInteger in a simple REPL.
// Controls: I am typing q or quit to exit.

using SplashKitSDK;
using static SplashKitSDK.SplashKit;

WriteLine("Is Integer Checker");
WriteLine("Type a value and press Enter. Type q to quit.");

bool running = true;
while (running)
{
    Write("> ");
    string? text = ReadLine();

    if (text == null)
    {
        break;
    }

    if (text == "q" || text == "quit")
    {
        running = false;
    }
    else
    {
        // I am using IsInteger so I am learning the utility call
        if (IsInteger(text))
        {
            WriteLine("Integer");
        }
        else
        {
            WriteLine("Not integer");
        }
    }
}

WriteLine("Bye");