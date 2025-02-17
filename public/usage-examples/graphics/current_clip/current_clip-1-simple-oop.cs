using SplashKitSDK;

public class Program
{
    public static void Main()
    {   
        // Open a window with the title "Current Clip" and dimensions
        Window window = SplashKit.OpenWindow("Current Clip", 800, 600);
        
        // Push a clipping area
        Rectangle rectangle = SplashKit.CurrentClip();
        // Display information about the current clipping area (Width and Height) in the window
        SplashKit.DrawText($"Current Clip: Width:{rectangle.Width} Height:{rectangle.Height}", Color.Black, "Arial", 24, 100, 100);
        
        // Refresh the screen to display the text
        SplashKit.RefreshScreen();
        
        // Wait for 5 seconds to observe the clipping area information
        SplashKit.Delay(5000);

        // Close the window
        SplashKit.CloseAllWindows();
    }
}
