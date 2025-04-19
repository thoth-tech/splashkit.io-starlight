using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = new Window("Font Style", 800, 60);
LoadFont("Arial", "Arial.TTF");

// Initialise Default message
string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

while (!window.CloseRequested)
{
    ProcessEvents();

    // Check key presses and update font style
    if (KeyTyped(KeyCode.NKey))
    {
        SetFontStyle("Arial", FontStyle.NormalFont);
    }
    else if (KeyTyped(KeyCode.BKey))
    {
        SetFontStyle("Arial", FontStyle.BoldFont);
    }
    else if (KeyTyped(KeyCode.IKey))
    {
        SetFontStyle("Arial", FontStyle.ItalicFont);
    }
    else if (KeyTyped(KeyCode.UKey))
    {
        SetFontStyle("Arial", FontStyle.UnderlineFont);
    }

    // Clear screen and draw updated message
    ClearScreen(Color.White);
    DrawText(message, Color.Black, "Arial", 20, 50, 20);
    // Refresh the window with the updated text
    RefreshScreen();
}

Delay(5000);
CloseAllWindows();
