using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("Check Fullscreen", 800, 600);

// Check if the window is in fullscreen mode
bool isFullscreen = CurrentWindowIsFullscreen();
WriteLine("Is the current window fullscreen? " + isFullscreen);

// Close the window
Delay(3000);  
CloseWindow("Check Fullscreen");
