using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Style Changer", 800, 120);
Font arial = LoadFont("Arial", "Arial.TTF");

// Initialise Default message
string instructions = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

while (!QuitRequested())
{
    ProcessEvents();

    // Check key presses and update font style
    if (KeyTyped(KeyCode.NKey))
    {
        SetFontStyle(arial, FontStyle.NormalFont);
    }
    else if (KeyTyped(KeyCode.BKey))
    {
        SetFontStyle(arial, FontStyle.BoldFont);
    }
    else if (KeyTyped(KeyCode.IKey))
    {
        SetFontStyle(arial, FontStyle.ItalicFont);
    }
    else if (KeyTyped(KeyCode.UKey))
    {
        SetFontStyle(arial, FontStyle.UnderlineFont);
    }

    // Clear screen and draw updated message
    ClearScreen(Color.White);
    DrawText(instructions, Color.Black, arial, 20, 50, 20);
    RefreshScreen();
}

Delay(5000);
CloseAllWindows();
