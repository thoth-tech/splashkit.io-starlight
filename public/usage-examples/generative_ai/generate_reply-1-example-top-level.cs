using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interactive AI Terminal", 900, 600);

WriteLine("Interactive AI Terminal (Single-Turn)");
Write("Enter your prompt: ");
string prompt = ReadLine();

string reply = GenerateReply(prompt);

WriteLine("\nAI reply:");
WriteLine(reply);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());
    DrawText("Interactive AI Terminal", ColorBlack(), 20, 20);
    DrawText("Prompt:", ColorBlack(), 20, 70);
    DrawText(prompt, ColorDarkSlateGray(), 20, 100);
    DrawText("AI Reply:", ColorBlack(), 20, 160);
    DrawText(reply, ColorBlue(), 20, 190);

    RefreshScreen(60);
}

CloseAllWindows();