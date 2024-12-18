using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window
        Window window = SplashKit.OpenWindow("Display Name", 800, 600);
       

        // Draw display details
        for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
        {
            // Retrieve display details
            var display = SplashKit.DisplayDetails(i);

            // Write display details to the screen
            SplashKit.DrawText($"NAME: {display.Name}", Color.Black, "Arial", 24, 100, 100);
            

        }

        // Refresh the screen to show drawn text
        SplashKit.RefreshScreen();

        // Pause for 3 seconds to allow viewing
        SplashKit.Delay(3000);

        // Close the window
        SplashKit.CloseAllWindows();
    }
}
