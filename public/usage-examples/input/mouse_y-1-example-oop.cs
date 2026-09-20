using SplashKitSDK;

namespace MouseYExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Mouse Height Gauge", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Read the height once so the line, the bar and the text always agree
                float pointerHeight = SplashKit.MouseY();

                SplashKit.ClearScreen(Color.White);

                // The bar grows from the bottom of the window up to the pointer
                SplashKit.FillRectangle(Color.Blue, 340, pointerHeight, 120, 600 - pointerHeight);
                SplashKit.DrawLine(Color.Red, 0, pointerHeight, 800, pointerHeight);

                SplashKit.DrawText("Move the mouse up and down to change the gauge.", Color.Black, 20, 20);
                SplashKit.DrawText("Mouse Y: " + (int)pointerHeight, Color.Black, 20, 60);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
