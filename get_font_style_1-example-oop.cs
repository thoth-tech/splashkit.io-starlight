using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        Window window = new Window("Font Style", 1100, 120);
        string fontName = "Arial";
        SplashKit.LoadFont(fontName, "Arial.TTF");

        string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();

            // Check key presses and update font style and message
            if (SplashKit.KeyTyped(KeyCode.NKey))
            {
                SplashKit.SetFontStyle(fontName, FontStyle.NormalFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.BKey))
            {
                SplashKit.SetFontStyle(fontName, FontStyle.BoldFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.IKey))
            {
                SplashKit.SetFontStyle(fontName, FontStyle.ItalicFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.UKey))
            {
                SplashKit.SetFontStyle(fontName, FontStyle.UnderlineFont);
            }

            message = $"Font style set to {SplashKit.GetFontStyle(fontName)}. Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

            // Clear screen and draw updated message
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(message, Color.Black, fontName, 20, 50, 20);
            // Refresh the window with the updated text
            window.Refresh(60);
        }

        SplashKit.Delay(5000);
        SplashKit.CloseAllWindows();
    }
}
