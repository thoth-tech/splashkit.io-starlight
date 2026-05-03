using SplashKitSDK;

namespace CurrentWindowPositionExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Live Window Position Monitor", 700, 250);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Point2D pos = SplashKit.CurrentWindowPosition();
                int x = SplashKit.CurrentWindowX();
                int y = SplashKit.CurrentWindowY();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Move the window to see the values update", Color.Black, 20, 20);
                SplashKit.DrawText("Current Window Position: (" + (int)pos.X + ", " + (int)pos.Y + ")", Color.Blue, 20, 70);
                SplashKit.DrawText("Current Window X: " + x, Color.Red, 20, 110);
                SplashKit.DrawText("Current Window Y: " + y, Color.Green, 20, 150);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}