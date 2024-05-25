using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Open a window with a specific name
Window myWindow = OpenWindow("Close Named Window Example", 800, 600);

// Display a message and wait for a few seconds
WriteLine("The window will close in 5 seconds...");
Delay(5000);

// Close the window with the specified name
CloseWindow("Close Named Window Example");

