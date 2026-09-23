using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Presentation Mode", 800, 450);

while (!QuitRequested())
{
    ProcessEvents();

    // Toggling means the same key can both enter and leave fullscreen
    if (KeyTyped(KeyCode.FKey))
    {
        CurrentWindowToggleFullscreen();
    }

    // Draw for the new state so the screen shows which mode the window is in
    if (CurrentWindowIsFullscreen())
    {
        ClearScreen(ColorBlack());
        DrawText("Fullscreen mode", ColorWhite(), "arial", 48, 40, 60);
        DrawText("Press F to leave fullscreen", ColorLightGray(), "arial", 28, 40, 150);
    }
    else
    {
        ClearScreen(ColorWhite());
        DrawText("Windowed mode", ColorBlack(), "arial", 48, 40, 60);
        DrawText("Press F to enter fullscreen", ColorDarkGray(), "arial", 28, 40, 150);
    }

    RefreshScreen(60);
}

CloseAllWindows();
