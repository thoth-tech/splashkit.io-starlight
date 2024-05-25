using static SplashKitSDK.SplashKit;  
using SplashKitSDK;  

// Open two windows
Window window1 = OpenWindow("Window 1", 800, 600);
Window window2 = OpenWindow("Window 2", 800, 600);

// Display a message and wait for a few seconds
WriteLine("Activating Window 2 and then retrieving the current window in 5 seconds...");
Delay(5000);

// Retrieve the current active window by switching context
Window current = CurrentWindow();

// Print the title of the current active window
WriteLine("The current active window is: " + WindowCaption(current));

// Close the windows
CloseWindow(window1);
CloseWindow(window2);

