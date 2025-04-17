using System;
using SplashKitSDK;

class Program
{
    static void Main()
    {
        Window window = new Window("Font Style", 800, 120);
        // Load Font
        SplashKit.LoadFont("Arial", "Arial.TTF");

        // Default Message
        string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
        string message1 = "";

        while (!window.CloseRequested)
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

            message1 = $"Font style set to {SplashKit.GetFontStyle("Arial")}.";

            // Clear screen and draw updated message
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(message, Color.Black, "Arial", 20, 50, 20);
            SplashKit.DrawText(message1, Color.Black, "Arial", 20, 50, 80);
            // Refresh the window with updated text
            SplashKit.RefreshScreen();
        }

        SplashKit.Delay(5000);
        SplashKit.CloseAllWindows();
    }
}
