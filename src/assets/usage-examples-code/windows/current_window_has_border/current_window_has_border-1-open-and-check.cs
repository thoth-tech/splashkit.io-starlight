using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("Test Window", 800, 600);

// Check if the current window has a border
bool hasBorder = CurrentWindowHasBorder();

// Display the result
WriteLine("Does the current window have a border? " + (hasBorder ? "Yes" : "No"));
