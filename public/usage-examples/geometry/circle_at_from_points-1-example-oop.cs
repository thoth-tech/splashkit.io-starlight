using SplashKitSDK;

namespace CircleAtExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Blue Circle at the centre", 800, 600);

            // Create a circle at (400, 300) with radius 100
            Circle circle = SplashKit.CircleAt(400, 300, 100);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                // Draw the circle
                SplashKit.FillCircle(Color.Blue, circle);
                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
