using SplashKitSDK;

namespace LabelElementExample
{
    public class Program
    {
        public static void Main()
        {
            // Open a window
            Window window = new Window("SplashKit Interface Demo", 600, 400);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                // Define the main panel
                Rectangle main_panel_area = SplashKit.RectangleFrom(50, 50, 500, 300);

                // Create the panel
                SplashKit.StartPanel("MainPanel", main_panel_area);

                // Add label to the panel
                SplashKit.LabelElement("Welcome to the SplashKit Interface!");
                SplashKit.EndPanel("MainPanel");

                // Draw all panels and interface elements
                SplashKit.DrawInterface();

                SplashKit.RefreshScreen(60);
            }
        }
    }
}
