using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window
            SplashKit.OpenWindow("Display Detail", 800, 600);

        // Loop through all displays and print their details
            for (uint i = 0; i < SplashKit.NumberOfDisplays(); i++)
            {
                // Retrieve display details
                var display = SplashKit.DisplayDetails(i);

                // Write display details to the console
                
                SplashKit.DrawText($"  Name: {display.Name}", Color.Black, "Arial", 24, 100, 100);
                SplashKit.DrawText($"  Resolution: {display.Width} X {display.Height}", Color.Black, "Arial", 24, 100, 200);
                
            }

            // Refresh the screen to show drawn text
            SplashKit.RefreshScreen();

            // Keep the window open for 3 seconds
            SplashKit.Delay(3000);

            // Close the window
            SplashKit.CloseAllWindows();

    }
}
