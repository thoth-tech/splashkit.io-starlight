using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Style", 800, 120);
LoadFont("Arial", "Arial.TTF");

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

    fontText = $"Font style set to ";
    style = GetFontStyle("Arial");
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
    DrawText(infoText, Color.Black, FontNamed("Arial"), 20, 50, 20);
    DrawText(fontText, Color.Black, FontNamed("Arial"), 20, 50, 80);
    RefreshScreen();
}

Delay(5000);
CloseAllWindows();
