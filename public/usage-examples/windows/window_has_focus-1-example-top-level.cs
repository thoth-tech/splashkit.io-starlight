using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Window Has Focus", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Check whether the current window has focus
    bool hasFocus = WindowHasFocus(CurrentWindow());

    ClearScreen(ColorWhite());

    // Show the current focus state on screen
    DrawText("Click on or away from the window to change focus.", ColorBlack(), 120, 220);

    if (hasFocus)
    {
        DrawText("Window has focus", ColorGreen(), 280, 280);
    }
    else
    {
        DrawText("Window does not have focus", ColorRed(), 240, 280);
    }

    RefreshScreen(60);
}

CloseAllWindows();