using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        SplashKit.OpenWindow("Font Style", 800, 120);
        // Load Font
        SplashKit.LoadFont("Arial", "Arial.TTF");

        // Default Message
        string InitialText = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
        string FontText = "";
        FontStyle style = FontStyle.NormalFont;
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();

            // Check key presses and update font style and message
            if (SplashKit.KeyTyped(KeyCode.NKey))
            {
                SplashKit.SetFontStyle("Arial", FontStyle.NormalFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.BKey))
            {
                SplashKit.SetFontStyle("Arial", FontStyle.BoldFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.IKey))
            {
                SplashKit.SetFontStyle("Arial", FontStyle.ItalicFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.UKey))
            {
                SplashKit.SetFontStyle("Arial", FontStyle.UnderlineFont);
            }

            FontText = $"Font style set to ";
            style = SplashKit.GetFontStyle("Arial");
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
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(InitialText, Color.Black, "Arial", 20, 50, 20);
            SplashKit.DrawText(FontText, Color.Black, "Arial", 20, 50, 80);
            // Refresh the window with updated text
            SplashKit.RefreshScreen();
        }

        SplashKit.Delay(5000);
        SplashKit.CloseAllWindows();
    }
}
