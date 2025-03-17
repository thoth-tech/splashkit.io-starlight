using SplashKitSDK;

namespace LineFromExample
{
    public class Program
    {
        public static void Main()
        {
            // Open window
            Window window = new Window("Basic Line Drawing", 300, 300);
            // Initialise start and end points for line
            Point2D start = SplashKit.PointAtOrigin();
            Point2D end = SplashKit.PointAtOrigin();

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                    // Get start point from cursor on left click and end point on right click
                    if (SplashKit.MouseClicked(MouseButton.LeftButton))
                    {
                        start = SplashKit.MousePosition();
                    }
                    else if (SplashKit.MouseClicked(MouseButton.RightButton))
                    {
                        end = SplashKit.MousePosition();
                    }
                                // Create a line between the points
                Line line = SplashKit.LineFrom(start, end);
                // Draw the line in red
                SplashKit.ClearScreen();
                SplashKit.DrawLine(Color.Red, line);
                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}