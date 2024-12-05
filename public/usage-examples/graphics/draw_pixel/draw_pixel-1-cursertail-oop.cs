using SplashKitSDK;

namespace DrawPixel
{
    public class Program
    {
        public static void Main()
        {
            // Declare variables
            const int TrailLength = 50;
            Point2D MousePoint;
            Point2D[] MouseHistory = new Point2D[TrailLength];
            Color[] ColorList = { Color.Blue, Color.Red, Color.Green, Color.Yellow, Color.Pink };

            Window window = new Window("Cursor Trail", 600, 600);

            while (!SplashKit.QuitRequested())
            {
                MousePoint = SplashKit.MousePosition();
                window.Clear(Color.Black);
                // Set mouse position history
                for (int i = 0; i < TrailLength - 1; i++)
                {
                    // Shuffle forward
                    MouseHistory[i] = MouseHistory[i + 1];
                }

                MouseHistory[TrailLength - 1] = MousePoint;

                // Draw mouse trail
                for (int i = 0; i < TrailLength; i++)
                {
                    SplashKit.DrawPixel(ColorList[i % 5], MouseHistory[i]);
                }

                SplashKit.ProcessEvents();
                window.Refresh(60);
            }
            window.Close();
        }
    }
}