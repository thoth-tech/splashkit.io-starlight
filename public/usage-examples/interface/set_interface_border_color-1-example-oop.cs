using SplashKitSDK;

namespace BorderColorDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open a window for the border‐color demo
            SplashKit.OpenWindow("Border Interface Color", 400, 200);

            // Set all interface borders (e.g. buttons) to green
            SplashKit.SetInterfaceBorderColor(SplashKit.ColorRed());

            // Define a button area
            var btnRect = SplashKit.RectangleFrom(150, 80, 100, 40);

            // Main loop: draw the button with our custom border color
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // Render the button using the interface border color
                SplashKit.Button("Click Me", btnRect);
                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
