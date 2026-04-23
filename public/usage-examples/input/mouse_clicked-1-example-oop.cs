using System.Collections.Generic;
using SplashKitSDK;

namespace MouseClickedExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Click to Place Markers", 800, 600);

            List<Point2D> clicks = new();

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Add a marker where the left mouse button was clicked
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    clicks.Add(SplashKit.MousePosition());
                }

                SplashKit.ClearScreen();

                foreach (Point2D pt in clicks)
                {
                    SplashKit.FillCircle(Color.Red, pt.X, pt.Y, 8);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}