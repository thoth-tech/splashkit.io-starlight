using static SplashKitSDK.SplashKit;
using SplashKitSDK;

// Open a new window
Window wind = OpenWindow("Simple Welcome Screen", 800, 600);

// Keep the program running until the user closes the window
while (!QuitRequested())
{
    ProcessEvents();

    // Draw content on the screen
    ClearWindow(wind, ColorSkyBlue());
    FillRectangle(ColorWhite(), 220, 230, 360, 120);
    DrawText("Welcome to SplashKit!", ColorBlack(), 290, 270);
    DrawText("This window was opened using OpenWindow.", ColorBlack(), 245, 305);

    RefreshWindow(wind);
}

// Close all open windows
CloseAllWindows();
