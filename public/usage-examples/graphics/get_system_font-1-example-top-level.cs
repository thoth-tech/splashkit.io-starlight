using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("System Font Retriever and Displayer", 800, 600);

// Set the font variable to the system's default font if available
Font font = GetSystemFont();
            
while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());
    if (font != null)
    {
        DrawText("System font detected!", ColorBlack(), 300, 100);

        // Display some sample text to demonstrate the selected font
        DrawText("The quick brown fox jumps over the lazy dog", ColorBlack(), font, 30, 50, 150);
    }
    else
    {
        DrawText("No system font detected!", ColorBlack(), 300, 100);
    }
    RefreshScreen();
}
CloseAllWindows();