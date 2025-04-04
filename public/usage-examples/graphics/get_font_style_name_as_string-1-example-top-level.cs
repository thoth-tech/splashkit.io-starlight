using System;
using SplashKitSDK;

Window window = new Window("Font Style", 800, 120);

// Load font
Font myFont = SplashKit.LoadFont("Arial", "Arial.TTF");

// Default message
string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
string message1 = "";

while (!window.CloseRequested)
{
    SplashKit.ProcessEvents();

    // Check key presses and update font style
    if (SplashKit.KeyTyped(KeyCode.NKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.NormalFont);
    }
    else if (SplashKit.KeyTyped(KeyCode.BKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.BoldFont);
    }
    else if (SplashKit.KeyTyped(KeyCode.IKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.ItalicFont);
    }
    else if (SplashKit.KeyTyped(KeyCode.UKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.UnderlineFont);
    }

    message1 = $"Font style set to {SplashKit.GetFontStyle(myFont)}";

    // Clear screen and draw updated message
    SplashKit.ClearScreen(Color.White);
    SplashKit.DrawText(message, Color.Black, myFont, 20, 50, 20);
    SplashKit.DrawText(message1, Color.Black, myFont, 20, 50, 80);
    // Refresh the window with the updated text
    window.Refresh(60);
}

SplashKit.Delay(5000);
SplashKit.CloseAllWindows();
