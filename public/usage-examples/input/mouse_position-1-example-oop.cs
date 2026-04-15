using SplashKitSDK;

namespace MousePositionExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Position Display", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                Point2D mousePoint = SplashKit.MousePosition();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Move the mouse to track its position in the window.", Color.Black, 20, 20);
                SplashKit.DrawText("Mouse X: " + mousePoint.X, Color.Black, 20, 60);
                SplashKit.DrawText("Mouse Y: " + mousePoint.Y, Color.Black, 20, 100);

                SplashKit.FillCircle(Color.Blue, mousePoint.X, mousePoint.Y, 8);
                SplashKit.DrawCircle(Color.Black, mousePoint.X, mousePoint.Y, 8);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}