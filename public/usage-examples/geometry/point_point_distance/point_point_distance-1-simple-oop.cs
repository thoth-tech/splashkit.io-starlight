using SplashKitSDK;

namespace PointPointDistance
{
    public class Program
    {
        public static void Main()
        {
            // Create and initialise new window with title and dimensions
            Window wnd = SplashKit.OpenWindow("Distance From Center", 600, 600);
            SplashKit.ClearScreen();

            // Create circle at the center of window 
            SplashKit.FillCircleOnWindow(wnd, Color.Red, 300, 300, 6);
            SplashKit.RefreshScreen();
            
            // While window is open 
            while(!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Point of center 
                Point2D center = SplashKit.ScreenCenter();

                // Point of cursor position 
                Point2D mouse = SplashKit.MousePosition();

                // Print distance to terminal 
                SplashKit.WriteLine(SplashKit.PointPointDistance(center, mouse));
            }
            
            // Close all opened windows
            SplashKit.CloseAllWindows();

        }
    }
}