using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Font Style", 800, 120);
LoadFont("Arial", "Arial.TTF");

// Initialise Default message
string InitialText = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
string FontText = "";
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

    FontText = $"Font style set to ";
    style = GetFontStyle("Arial");
    switch (style)
    {
        case FontStyle.NormalFont:
            FontText += "Normal";
            break;
        case FontStyle.BoldFont:
            FontText += "Bold";
            break;
        case FontStyle.ItalicFont:
            FontText += "Italic";
            break;
        case FontStyle.UnderlineFont:
            FontText += "Underlined";
            break;
        default:
            FontText += "Unknown";
            break;
    }

    // Clear screen and draw updated message
    ClearScreen(Color.White);
    DrawText(InitialText, Color.Black, "Arial", 20, 50, 20);
    DrawText(FontText, Color.Black, "Arial", 20, 50, 80);
    RefreshScreen();
}

Delay(5000);
CloseAllWindows();
