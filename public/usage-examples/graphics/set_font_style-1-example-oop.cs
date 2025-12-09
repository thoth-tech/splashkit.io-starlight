using SplashKitSDK;

namespace SetFontStyleExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Choose Your Font", 800, 600);

            // Different fonts can be added to the fonts folder and used below ↓
            Font font = SplashKit.FontNamed("Century.ttf");
            Rectangle rectangle = SplashKit.RectangleFrom(100, 200, 150, 30);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                if (SplashKit.ReadingText() == false)
                {
                    SplashKit.StartReadingText(rectangle);
                }

                // Function used here ↓
                if (SplashKit.TextInput() == "1")
                {
                    SplashKit.SetFontStyle(font, FontStyle.BoldFont);
                }
                else if (SplashKit.TextInput() == "2")
                {
                    SplashKit.SetFontStyle(font, FontStyle.ItalicFont);
                }
                else if (SplashKit.TextInput() == "3")
                {
                    SplashKit.SetFontStyle(font, FontStyle.UnderlineFont);
                }
                else
                {
                    SplashKit.SetFontStyle(font, FontStyle.NormalFont);
                }

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Please select your desired font style (type numbers 1-3):", Color.Black, font, 15, 100, 60);
                SplashKit.DrawText("1 - Bold", Color.Black, font, 15, 100, 90);
                SplashKit.DrawText("2 - Italic", Color.Black, font, 15, 100, 120);
                SplashKit.DrawText("3 - Underline", Color.Black, font, 15, 100, 150);
                SplashKit.DrawRectangle(Color.Black, 100, 200, 150, 30);
                SplashKit.DrawText(SplashKit.TextInput(), Color.Black, 110, 210);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}