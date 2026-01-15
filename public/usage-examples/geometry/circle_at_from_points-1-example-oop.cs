using SplashKitSDK;

namespace CircleAtExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Flag of Japan", 600, 400);

            // Create a circle at (300, 200) with radius 120
            Circle circle = SplashKit.CircleAt(300, 200, 120);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                // Draw the circle
                SplashKit.FillCircle(Color.DarkRed, circle);
                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
