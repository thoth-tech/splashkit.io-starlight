using SplashKitSDK;
using static SplashKitSDK.SplashKit;
// Open a window titled "Fill Triangle On Bitmap Example" with dimensions 800x600
OpenWindow("Fill Triangle On Bitmap Example", 800, 600);

ClearScreen(ColorWhite());

// Create a bitmap named "triangle_bitmap" with dimensions 500x500
Bitmap myBitmap = CreateBitmap("triangle_bitmap", 500, 500);

// Clear the entire bitmap with a background color (e.g., light gray)
ClearBitmap(myBitmap, Color.LightGreen);

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

