using static SplashKitSDK.SplashKit;

// Open a window to find its height
OpenWindow("Window", 800, 600);

// Get the height of the current window
int height = CurrentWindowHeight();

// Print the height of the current window
WriteLine("The height of the current window is: " + height);

// Close the window
Delay(5000); 
CloseAllWindows();
