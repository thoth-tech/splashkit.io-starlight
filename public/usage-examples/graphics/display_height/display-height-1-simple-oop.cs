using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
        // Open a window
        Window window = SplashKit.OpenWindow("Display Height", 800, 600);
       

        // Draw display details
        for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
        {
            // Retrieve display details
            var display = SplashKit.DisplayDetails(i);

            // Write display height to the screen
            SplashKit.DrawText($"Height: {display.Height}", Color.Black, "Arial", 24, 100, 100);
            

        }

        // Refresh the screen to show drawn text
        SplashKit.RefreshScreen();

        // Pause for 3 seconds to allow viewing
        SplashKit.Delay(3000);

        // Close the window
        SplashKit.CloseAllWindows();
        }
    }
}
