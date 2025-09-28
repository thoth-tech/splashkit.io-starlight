using SplashKitSDK;

namespace FontNamedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Font Named", 800, 600);

            Font font;
            Rectangle rectangle = SplashKit.RectangleFrom(100, 200, 150, 30);
            
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                
                if (SplashKit.ReadingText() == false)
                {
                    SplashKit.StartReadingText(rectangle);
                }

                // User's string input is converted to a font variable via the font_named function
                // In this example, the .tff extension is automatically applied to the string for better usability
                // Alagard.ttf, Century.ttf and RobotoSlab.ttf as part of the program resources
                font = SplashKit.FontNamed(SplashKit.TextInput() + ".ttf");

                SplashKit.ClearScreen(Color.White);
                SplashKit.DrawText("Please input the name of the font you would like to use:", Color.Black, font, 15, 100, 60);
                SplashKit.DrawText("- Alagard", Color.Black, font, 15, 100, 90);
                SplashKit.DrawText("- Century", Color.Black, font, 15, 100, 120);
                SplashKit.DrawText("- RobotoSlab", Color.Black, font, 15, 100, 150);
                SplashKit.DrawRectangle(Color.Black, 100, 200, 150, 30);
                SplashKit.DrawText(SplashKit.TextInput(), Color.Black, font, 15, 105, 205);
                SplashKit.RefreshScreen();
            }
            SplashKit.CloseAllWindows();
        }
    }
}