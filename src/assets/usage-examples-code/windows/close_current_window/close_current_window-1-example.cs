using static SplashKitSDK.SplashKit;  
using SplashKitSDK; 

// Open a window
Window myWindow = OpenWindow("Close Current Window Example", 800, 600);

// Display a message and wait for a few seconds
WriteLine("The window will close in 5 seconds...");
Delay(5000);

// Close the current window
CloseCurrentWindow();
