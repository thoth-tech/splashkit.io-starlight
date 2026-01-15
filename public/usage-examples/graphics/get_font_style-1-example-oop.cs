using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Interactive Font Style Changer", 800, 120);
        // Load Font
        Font Arial = SplashKit.LoadFont("Arial", "Arial.TTF");

        // Default Message
        string infoText = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
        string fontText = "";
        FontStyle style = FontStyle.NormalFont;
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

            fontText = $"Font style set to ";
            style = SplashKit.GetFontStyle(Arial);


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
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawText(infoText, Color.Black, Arial, 20, 50, 20);
            SplashKit.DrawText(fontText, Color.Black, Arial, 20, 50, 80);
            // Refresh the window with updated text
            SplashKit.RefreshScreen();
        }

        SplashKit.Delay(5000);
        SplashKit.CloseAllWindows();
    }
}
