/**
 * Usage Example: using function fill_triangle_on_bitmap with colour red
 **/

using static SplashKitSDK.SplashKit;

public class Program
{
    public static void Main()
    {
        // Open a window titled "Fill Triangle On Bitmap Example" with dimensions 800x600
        OpenWindow("Fill Triangle On Bitmap Example", 800, 600);

        // Create a bitmap named "triangle_bitmap" with dimensions 800x600
        Bitmap myBitmap = CreateBitmap("triangle_bitmap", 800, 600);

        // Fill the triangle on the bitmap with red color
        FillTriangleOnBitmap(myBitmap, Color.Red, 100, 100, 200, 200, 300, 100);

        // Draw the bitmap to the screen
        DrawBitmap(myBitmap, 0, 0);

        // Refresh the screen to display the filled triangle on the bitmap
        RefreshScreen();

        // Pause for 5000 milliseconds (5 seconds) to observe the result
        Delay(5000);

        // Close all windows
        CloseAllWindows();
    }
}
