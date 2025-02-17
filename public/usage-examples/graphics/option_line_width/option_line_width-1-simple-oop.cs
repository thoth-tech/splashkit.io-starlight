using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Open a window titled "Ripple Effect" with dimensions 800x600
        SplashKit.OpenWindow("Ripple Effect", 800, 600);

        // Loop to draw 10 concentric circles with increasing radius and line width
        for (int i = 1; i <= 10; i++) 
        {
            // Draw a circle with a center at (200, 200), increasing radius and line width
            // The radius is multiplied by 15 for each iteration, and line width increases by 1 each time
            SplashKit.DrawCircle(Color.Blue, 200, 200, i * 15, SplashKit.OptionLineWidth(i));
        }

        // Refresh the screen to display the drawn circles
        SplashKit.RefreshScreen(); 

        // Pause the program for 5000 milliseconds (5 seconds) to allow viewing the effect
        SplashKit.Delay(5000);

        // Close the window after the delay
        SplashKit.CloseAllWindows();
    }
}
