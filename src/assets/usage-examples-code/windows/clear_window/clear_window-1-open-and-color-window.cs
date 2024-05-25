using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Open a window
Window myWindow = OpenWindow("Clear Window Example", 800, 600);

// Define a color to clear the window with
Color myColor = RGBColor(100, 149, 237);  // Cornflower Blue

// Clear the window with the specified color
ClearWindow(myWindow, myColor);

// Refresh the window to apply changes
RefreshWindow(myWindow);

// Pause to view the cleared window
Delay(5000);

// Close the window
CloseWindow(myWindow);
