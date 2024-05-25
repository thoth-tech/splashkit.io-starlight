using static SplashKitSDK.SplashKit;  
using SplashKitSDK; 

// Open a window
Window myWindow = OpenWindow("Close Window Example", 800, 600);

// Display a message and wait for a few seconds
WriteLine("The window will close in 5 seconds...");
Delay(5000);

// Close the window
CloseWindow(myWindow);
