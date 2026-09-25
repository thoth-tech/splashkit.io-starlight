using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Keep the caption in one variable so the window and the lookups can never disagree
string previewCaption = "Preview";

Window dashboardWindow = OpenWindow("Dashboard", 480, 280);
Window previewWindow = OpenWindow(previewCaption, 480, 280);

// Place the windows side by side so both stay visible
MoveWindowTo(dashboardWindow, 60, 100);
MoveWindowTo(previewWindow, 580, 100);

while (!QuitRequested())
{
    ProcessEvents();

    // The F key sends the preview window in and out of fullscreen
    if (KeyTyped(KeyCode.FKey))
    {
        WindowToggleFullscreen(previewCaption);
    }

    // Look the window up by its caption, so no window handle is needed here
    bool previewIsFullscreen = WindowIsFullscreen(previewCaption);

    // The whole dashboard acts as a status light
    if (previewIsFullscreen)
    {
        ClearWindow(dashboardWindow, ColorLightGreen());
        DrawTextOnWindow(dashboardWindow, "Preview is fullscreen", ColorBlack(), "arial", 30, 20, 60);
    }
    else
    {
        ClearWindow(dashboardWindow, ColorLightGray());
        DrawTextOnWindow(dashboardWindow, "Preview is windowed", ColorBlack(), "arial", 30, 20, 60);
    }

    DrawTextOnWindow(dashboardWindow, "Press F to toggle the preview", ColorDarkGray(), "arial", 20, 20, 140);
    RefreshWindow(dashboardWindow);

    ClearWindow(previewWindow, ColorLightBlue());
    DrawTextOnWindow(previewWindow, "Preview", ColorBlack(), "arial", 40, 20, 40);

    // The preview shows the same answer, because the dashboard is hidden while it fills the screen
    if (previewIsFullscreen)
    {
        DrawTextOnWindow(previewWindow, "Fullscreen: true", ColorBlack(), "arial", 30, 20, 120);
    }
    else
    {
        DrawTextOnWindow(previewWindow, "Fullscreen: false", ColorBlack(), "arial", 30, 20, 120);
    }

    DrawTextOnWindow(previewWindow, "Press F to toggle", ColorDarkGray(), "arial", 20, 20, 190);
    RefreshWindow(previewWindow);
}

CloseAllWindows();
