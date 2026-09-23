using SplashKitSDK;
using static SplashKitSDK.SplashKit;

void DrawWindowStatus(Window wnd, string name)
{
    // Ask this specific window, using its handle, whether it is fullscreen
    bool isFullscreen = WindowIsFullscreen(wnd);

    ClearWindow(wnd, ColorWhite());
    DrawTextOnWindow(wnd, name, ColorBlack(), "arial", 40, 20, 30);

    if (isFullscreen)
    {
        DrawTextOnWindow(wnd, "Fullscreen: true", ColorBlack(), "arial", 30, 20, 100);
    }
    else
    {
        DrawTextOnWindow(wnd, "Fullscreen: false", ColorBlack(), "arial", 30, 20, 100);
    }

    DrawTextOnWindow(wnd, "Press L or R to toggle a window", ColorDarkGray(), "arial", 20, 20, 170);
    RefreshWindow(wnd);
}

Window leftWindow = OpenWindow("Left Window", 480, 280);
Window rightWindow = OpenWindow("Right Window", 480, 280);

// Place the windows side by side so both stay visible
MoveWindowTo(leftWindow, 60, 100);
MoveWindowTo(rightWindow, 580, 100);

while (!QuitRequested())
{
    ProcessEvents();

    // Each key sends one window in or out of fullscreen
    if (KeyTyped(KeyCode.LKey))
    {
        WindowToggleFullscreen(leftWindow);
    }

    if (KeyTyped(KeyCode.RKey))
    {
        WindowToggleFullscreen(rightWindow);
    }

    // Every window reports its own state, so the text stays visible while it fills the screen
    DrawWindowStatus(leftWindow, "Left Window");
    DrawWindowStatus(rightWindow, "Right Window");
}

CloseAllWindows();
