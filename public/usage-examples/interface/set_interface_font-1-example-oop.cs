using SplashKitSDK;

namespace ButtonInterfaceFontDemo
{
    public class Program
    {
        public static void Main()
        {
            // Open window for the button font 
            SplashKit.OpenWindow("Button Interface Font", 800, 600);

            // Load and register the Courier font for UI elements
            SplashKit.LoadFont("courier", "courier.ttf");
            SplashKit.SetInterfaceFont("courier");

            // Define a button area
            var btnRect = SplashKit.RectangleFrom(300, 250, 200, 60);

            // Main loop: draw the button with our chosen interface font
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(SplashKit.ColorWhite());

                // Draw a button labeled "Click Me!" using the interface font
                SplashKit.Button("Click Me!", btnRect);

                // Render all interface elements
                SplashKit.DrawInterface();
                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
