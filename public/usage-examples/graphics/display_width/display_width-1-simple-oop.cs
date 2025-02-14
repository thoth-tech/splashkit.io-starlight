using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
        // Open a window
        Window window = SplashKit.OpenWindow("Display Width", 800, 600);
       

        // Draw display details
        for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
        {
            // Retrieve display details
            var display = SplashKit.DisplayDetails(i);

            // Write display width to the screen
            SplashKit.DrawText($"Width: {display.Width}", Color.Black, "Arial", 24, 100, 100);
            

        }

            // Refresh the screen to show drawn text
            SplashKit.RefreshScreen();

            // Keep the window open for 3 seconds
            SplashKit.Delay(3000);

            // Close the window
            SplashKit.CloseAllWindows();
        }
    }
}
