using SplashKitSDK;

namespace CurrentWindowExample
{
    public static class Program
    {
        public static void Main()
        {
            Window displayWindow = SplashKit.OpenWindow("Current Window Example", 800, 600);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                displayWindow = SplashKit.CurrentWindow();

                int width = SplashKit.WindowWidth(displayWindow);
                int height = SplashKit.WindowHeight(displayWindow);
                string caption = SplashKit.WindowCaption(displayWindow);
                string currentStatus = SplashKit.IsCurrentWindow(displayWindow).ToString();

                SplashKit.ClearWindow(displayWindow, Color.White);

                SplashKit.DrawText("Using current_window()", Color.Black, 20, 20);
                SplashKit.DrawText("Caption: " + caption, Color.Black, 20, 60);
                SplashKit.DrawText("Window Width: " + width, Color.Black, 20, 100);
                SplashKit.DrawText("Window Height: " + height, Color.Black, 20, 140);
                SplashKit.DrawText("Is Current Window: " + currentStatus, Color.Black, 20, 180);

                SplashKit.FillRectangle(Color.Blue, 20, 230, width - 40, 80);
                SplashKit.DrawText("This rectangle is drawn in the current window.", Color.White, 40, 260);

                SplashKit.RefreshWindow(displayWindow, 60U);
            }

            SplashKit.CloseWindow(displayWindow);
        }
    }
}