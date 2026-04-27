using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Mouse Shown", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();

    // Press S to show the mouse, H to hide it
    if (KeyTyped(KeyCode.SKey))
        ShowMouse();

    if (KeyTyped(KeyCode.HKey))
        HideMouse();

    // MouseShown returns true if the mouse cursor is currently visible
    string status;
    if (MouseShown())
        status = "Mouse is visible";
    else
        status = "Mouse is hidden";

    ClearScreen(ColorWhite());
    DrawText("Press S to show the mouse, H to hide it", ColorBlack(), "Arial", 18, 170, 250);
    DrawText(status, ColorBlue(), "Arial", 24, 170, 290);
    RefreshScreen(60);
}

// Always show the mouse again before closing
ShowMouse();
CloseAllWindows();
