using SplashKitSDK;

namespace shapes
{
    public class Program
    {
        public static void Main()
        {
            // Create a new window with the title "Fill Rectangle" and size 800x600 pixels
            Window window = new Window("Fill Rectangle", 800, 600);

            // Fill a rectangle with the color blue at position (200, 200), with width 200 and height 100
            window.FillRectangle(Color.Blue, 200, 200, 200, 100);
    
            // Refresh the window to display the updated content (i.e., the filled rectangle)
            window.Refresh();

            // Delay for 1 second to allow the window to remain open before closing
            SplashKit.Delay(1000);
        }
    }
}
