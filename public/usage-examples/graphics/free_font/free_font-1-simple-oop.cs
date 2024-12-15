using SplashKitSDK;

namespace LoadFont
{
    public class Program
    {
        public static void Main()
        {
            // Open new window
            Window wnd = SplashKit.OpenWindow("Font Styles", 600, 500);
            SplashKit.ClearScreen();

            // Load first font
            Font font1 = SplashKit.LoadFont("BebasNeue", "BebasNeue.ttf");

            // Draw text with font 
            SplashKit.DrawTextOnWindow(wnd, "This font is called Bebas Neue", Color.Black, font1, 30, 150, 210);
            SplashKit.DrawTextOnWindow(wnd, "The font style is Regular 400", Color.Black, font1, 30, 150, 240);
            SplashKit.RefreshScreen();

            SplashKit.Delay(3000);

             // Free font1
            SplashKit.FreeFont(font1);

            // Clear Screen 
            SplashKit.ClearScreen();

            // Load second font
            Font font2 = SplashKit.LoadFont("NunitoSans", "NunitoSans.ttf");

            // Draw text with font
            SplashKit.DrawTextOnWindow(wnd, "This font is called Nunito Sans", Color.Black, font2, 30, 120, 210);
            SplashKit.DrawTextOnWindow(wnd, "The font style is Extra Light 200", Color.Black, font2, 30, 120, 240);
            SplashKit.RefreshScreen();

            SplashKit.Delay(3000);

            // Free font2
            SplashKit.FreeFont(font2);
            
            // Close window
            SplashKit.CloseAllWindows();
        }

    }
}