using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window titled "Fill Triangle Example" with dimensions 800x600
OpenWindow("Fill Triangle Example", 800, 600);

ClearScreen(ColorWhite());

// Fill a triangle with vertices (100, 100), (200, 200), and (300, 100) with red color
FillTriangle(Color.Red, 100, 100, 200, 200, 300, 100);

// Refresh the screen to display the filled triangle
RefreshScreen();

// Pause for 5000 milliseconds (5 seconds) to observe the result
Delay(5000);

// Close all windows
CloseAllWindows();

