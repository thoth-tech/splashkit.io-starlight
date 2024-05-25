using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Open a window to get the current window position
OpenWindow("Check Fullscreen", 800, 600);

// Get the current window position
Point2D windowPosition = CurrentWindowPosition();

// Print the window position
WriteLine($"The current window position is: ({windowPosition.X}, {windowPosition.Y})");
