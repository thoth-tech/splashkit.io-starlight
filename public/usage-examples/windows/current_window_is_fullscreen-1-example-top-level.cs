using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Fullscreen Checker", 800, 450);

while (!QuitRequested())
{
    ProcessEvents();

    // Give the player a way to change the state that we are about to check
    if (KeyTyped(KeyCode.FKey))
    {
        CurrentWindowToggleFullscreen();
    }

    ClearScreen(ColorWhite());

    // Check every frame so the text always matches what the window is doing
    bool isFullscreen = CurrentWindowIsFullscreen();

    if (isFullscreen)
    {
        DrawText("Fullscreen: true", ColorBlack(), "arial", 48, 40, 60);
    }
    else
    {
        DrawText("Fullscreen: false", ColorBlack(), "arial", 48, 40, 60);
    }

    DrawText("Press F to switch", ColorDarkGray(), "arial", 28, 40, 150);

    RefreshScreen(60);
}

CloseAllWindows();
