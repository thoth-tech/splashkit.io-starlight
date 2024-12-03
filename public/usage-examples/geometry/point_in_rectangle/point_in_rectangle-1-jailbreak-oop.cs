using SplashKitSDK;

namespace PointInRectangle
{
    public class Program
    {
        public static void Main()
        {
            // Variable Declarations
            Point2D MousePoint;
            Rectangle Boundary = SplashKit.RectangleFrom(150, 150, 300, 100);

            Window Window = new Window("Cursor Jail", 600, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                // Get mouse position and draw boundary to screen
                MousePoint = SplashKit.MousePosition();
                Window.Clear(Color.Green);
                Window.FillRectangle(SplashKit.ColorWhite(), Boundary);

                // Check if mouse is in the boundary
                if (!SplashKit.PointInRectangle(MousePoint, Boundary))
                {
                    // Flash screen red and blue if mouse has escaped boundary
                    Window.Clear(Color.DarkRed);
                    Window.FillRectangle(Color.White, Boundary);
                    Window.DrawText("JAILBREAK", Color.Black, 250.0, 400.0);
                    SplashKit.RefreshScreen(2);
                    Window.Clear(Color.RoyalBlue);
                    Window.FillRectangle(Color.White, Boundary);
                    SplashKit.RefreshScreen(2);
                }
                Window.Refresh();
            }
            Window.Close();
        }
    }
}
