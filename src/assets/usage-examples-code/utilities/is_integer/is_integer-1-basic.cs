// I am reading text until the user types q, and I am printing whether each line is an integer.

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
        // I am using SplashKit IsInteger to demonstrate the utility
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