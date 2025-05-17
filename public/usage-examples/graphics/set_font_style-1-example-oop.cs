using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Font Style Changer", 800, 120);
        // Load Font
        Font Arial = SplashKit.LoadFont("Arial", "Arial.TTF");

        // Default Message
        string instructions = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();

            // Check key presses and update font style and message
            if (SplashKit.KeyTyped(KeyCode.NKey))
            {
                SplashKit.SetFontStyle(Arial, FontStyle.NormalFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.BKey))
            {
                SplashKit.SetFontStyle(Arial, FontStyle.BoldFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.IKey))
            {
                SplashKit.SetFontStyle(Arial, FontStyle.ItalicFont);
            }
            else if (SplashKit.KeyTyped(KeyCode.UKey))
            {
                SplashKit.SetFontStyle(Arial, FontStyle.UnderlineFont);
            }

            // Clear screen and draw updated message
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(instructions, Color.Black, Arial, 20, 50, 20);
            SplashKit.RefreshScreen();
        }

        SplashKit.Delay(5000);
        SplashKit.CloseAllWindows();
    }
}
