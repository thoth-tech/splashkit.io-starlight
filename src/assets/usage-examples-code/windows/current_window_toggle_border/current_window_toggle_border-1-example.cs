using static SplashKitSDK.SplashKit;

// Open a window
OpenWindow("Toggle Border", 800, 600);

// Toggle the window border
CurrentWindowToggleBorder();

// Wait for a key press before closing the window
while (!QuitRequested())
{
    ProcessEvents();
}
