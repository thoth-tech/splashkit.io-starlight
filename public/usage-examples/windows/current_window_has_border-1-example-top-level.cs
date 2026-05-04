using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Current Window Has Border", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Press B to toggle the current window border
    if (KeyTyped(KeyCode.BKey))
    {
        CurrentWindowToggleBorder();
    }

    // Check whether the current window has a border
    bool hasBorder = CurrentWindowHasBorder();

    ClearScreen(ColorWhite());

    // Show the current border state on screen
    DrawText("Press B to toggle the window border.", ColorBlack(), 170, 220);

    if (hasBorder)
    {
        DrawText("Current window has a border", ColorGreen(), 210, 280);
    }
    else
    {
        DrawText("Current window does not have a border", ColorRed(), 150, 280);
    }

    RefreshScreen(60);
}

CloseAllWindows();