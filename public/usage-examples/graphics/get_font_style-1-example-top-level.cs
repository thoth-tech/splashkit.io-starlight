using System;
using SplashKitSDK;

Window window = new Window("Font Style", 1100, 120);

// Load font
Font myFont = SplashKit.LoadFont("Arial", "Arial.TTF");

// Default message
string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

while (!window.CloseRequested)
{
    SplashKit.ProcessEvents();

    // Check key presses and update font style
    if (SplashKit.KeyTyped(KeyCode.NKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.NormalFont);
        message = $"Font style set to {SplashKit.GetFontStyle(myFont)}. Press B for Bold, I for Italics, or U for Underlined.";
    }
    else if (SplashKit.KeyTyped(KeyCode.BKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.BoldFont);
        message = $"Font style set to {SplashKit.GetFontStyle(myFont)}. Press N for Normal, I for Italics, or U for Underlined.";
    }
    else if (SplashKit.KeyTyped(KeyCode.IKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.ItalicFont);
        message = $"Font style set to {SplashKit.GetFontStyle(myFont)}. Press N for Normal, B for Bold, or U for Underlined.";
    }
    else if (SplashKit.KeyTyped(KeyCode.UKey))
    {
        SplashKit.SetFontStyle(myFont, FontStyle.UnderlineFont);
        message = $"Font style set to {SplashKit.GetFontStyle(myFont)}. Press N for Normal, B for Bold, or I for Italics.";
    }

    // Clear screen and draw updated message
    SplashKit.ClearScreen(Color.White);
    SplashKit.DrawText(message, Color.Black, myFont, 20, 50, 20);
    // Refresh the window with the updated text
    window.Refresh(60);
}

SplashKit.Delay(5000);
SplashKit.CloseAllWindows();
