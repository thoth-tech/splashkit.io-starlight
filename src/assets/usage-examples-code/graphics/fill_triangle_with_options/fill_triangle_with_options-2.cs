/**
 * Usage Example: Fill a scaled triangle with drawing options using SplashKit.
 **/
 using SplashKitSDK;

class Program
{
    static void Main(string[] args)
    {
        // Open a window titled "Fill Triangle With Options Example" with dimensions 800x600
        SplashKit.OpenWindow("Fill Triangle With Options Example", 800, 600);

        // Initialize drawing options with default settings
        DrawingOptions opts = DrawingOptions.Default;

        // Set the scale to 1.5 (150%)
        opts.ScaleX = 1.5;
        opts.ScaleY = 1.5;

        // Define the vertices of the triangle
        double x1 = 100, y1 = 100;
        double x2 = 200, y2 = 200;
        double x3 = 300, y3 = 100;

        // Scale each vertex of the triangle
        double scaledX1 = x1 * opts.ScaleX;
        double scaledY1 = y1 * opts.ScaleY;
        double scaledX2 = x2 * opts.ScaleX;
        double scaledY2 = y2 * opts.ScaleY;
        double scaledX3 = x3 * opts.ScaleX;
        double scaledY3 = y3 * opts.ScaleY;

        // Fill the scaled triangle with red color
        SplashKit.FillTriangle(Color.Red, scaledX1, scaledY1, scaledX2, scaledY2, scaledX3, scaledY3, opts);

        // Refresh the screen to display the filled scaled triangle
        SplashKit.RefreshScreen();

        // Pause for 5000 milliseconds (5 seconds) to observe the result
        SplashKit.Delay(5000);

        // Close all windows
        SplashKit.CloseAllWindows();
    }
}
