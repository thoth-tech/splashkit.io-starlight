using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interactive Font Style Changer", 800, 120);
Font arial = LoadFont("Arial", "Arial.TTF");

// Initialise Default message
string infoText = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
string fontText = "";
FontStyle style = FontStyle.NormalFont;

while (!SplashKit.QuitRequested())
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

    fontText = $"Font style set to ";
    style = GetFontStyle(arial);
    switch (style)
    {
        case FontStyle.NormalFont:
            fontText += "Normal";
            break;
        case FontStyle.BoldFont:
            fontText += "Bold";
            break;
        case FontStyle.ItalicFont:
            fontText += "Italic";
            break;
        case FontStyle.UnderlineFont:
            fontText += "Underlined";
            break;
        default:
            fontText += "Unknown";
            break;
    }

    // Clear screen and draw updated message
    ClearScreen(Color.White);
    DrawText(infoText, Color.Black, arial, 20, 50, 20);
    DrawText(fontText, Color.Black, arial, 20, 50, 80);
    RefreshScreen();
}

Delay(5000);
CloseAllWindows();
