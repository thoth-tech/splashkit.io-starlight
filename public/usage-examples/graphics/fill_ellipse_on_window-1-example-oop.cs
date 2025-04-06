using SplashKitSDK;

namespace FillEllipseOnWindow
{
    public class Program
    {
        public static void Main()
        {
            // Open new windows
            Window whiteWindow = SplashKit.OpenWindow("Ellipse Painter on White", 500, 500);
            Window blueWindow = SplashKit.OpenWindow("Ellipse Painter on Blue", 500, 500);
            
            // Set windows' postions
            SplashKit.MoveWindowTo(whiteWindow, 100, 100);
            SplashKit.MoveWindowTo(blueWindow, 620, 100);

            // Clear windows to white and blue
            SplashKit.ClearWindow(whiteWindow, Color.White);
            SplashKit.ClearWindow(blueWindow, Color.Aqua);

            // While user doesn't request to quit windows
            while (!whiteWindow.CloseRequested && !blueWindow.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.DrawTextOnWindow(whiteWindow, "Press L to paint. Press on the C key to clear screen", Color.Black, 5, 10);
                SplashKit.DrawTextOnWindow(blueWindow, "Press P to paint. Press on the D key to clear screen", Color.Black, 5, 10);

                // Get random points on the windows
                Point2D whitePos = SplashKit.RandomWindowPoint(whiteWindow);
                Point2D bluePos = SplashKit.RandomWindowPoint(blueWindow);

                // If L key is pressed draw ellipse on whiteWindow in random point
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    SplashKit.FillEllipseOnWindow(whiteWindow, SplashKit.RandomColor(), whitePos.X, whitePos.Y, 100, 50);
                }
                
                // If P key is pressed draw ellipse on blueWindow in random point
                if (SplashKit.KeyTyped(KeyCode.PKey))
                {
                    SplashKit.FillEllipseOnWindow(blueWindow, SplashKit.RandomColor(), bluePos.X, bluePos.Y, 100, 50);
                }

                // Clear whiteWindow if C key is pressed 
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    SplashKit.ClearWindow(whiteWindow, Color.White);
                }

                // Clear blueWindow if D key is pressed 
                if (SplashKit.KeyTyped(KeyCode.DKey))
                {
                    SplashKit.ClearWindow(blueWindow, Color.Aqua);
                }

                SplashKit.RefreshWindow(whiteWindow, 60);
                SplashKit.RefreshWindow(blueWindow, 60);
            }
            
            // Close all windows
            SplashKit.CloseAllWindows();
        }
    }
}