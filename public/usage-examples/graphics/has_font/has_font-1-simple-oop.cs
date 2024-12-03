using SplashKitSDK;

namespace HasFont
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Has Font", 800, 600);
            SplashKit.ClearScreen();

            // Check if the font exists
            bool fontCheck = SplashKit.HasFont("NORMAL_FONT");

            // Display the result
            if (fontCheck)
            {
                SplashKit.DrawText("Font found!", Color.Black, 300, 300);
            }
            else
            {
                SplashKit.DrawText("Font not found!", Color.Black, 300, 300);
            }
            
            SplashKit.RefreshScreen();
            SplashKit.Delay(4000);
            SplashKit.CloseAllWindows();
        }
    }
}