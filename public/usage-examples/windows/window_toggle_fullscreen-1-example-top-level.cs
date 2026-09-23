using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window notesWindow = OpenWindow("Presenter Notes", 480, 280);
Window projectorWindow = OpenWindow("Projector", 480, 280);

// Place the windows side by side so both stay visible
MoveWindowTo(notesWindow, 60, 100);
MoveWindowTo(projectorWindow, 580, 100);

int toggleCount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    // Only the projector goes fullscreen, so the notes stay on the presenter's own screen
    if (KeyTyped(KeyCode.FKey))
    {
        WindowToggleFullscreen(projectorWindow);
        toggleCount++;
    }

    ClearWindow(notesWindow, ColorWhite());
    DrawTextOnWindow(notesWindow, "Presenter Notes", ColorBlack(), "arial", 40, 20, 40);
    DrawTextOnWindow(notesWindow, "Press F to toggle the projector", ColorDarkGray(), "arial", 20, 20, 130);
    RefreshWindow(notesWindow);

    // Show the count on the projector itself, because the notes are hidden while it fills the screen
    if (WindowIsFullscreen(projectorWindow))
    {
        ClearWindow(projectorWindow, ColorBlack());
        DrawTextOnWindow(projectorWindow, "Big Slide", ColorWhite(), "arial", 40, 20, 40);
        DrawTextOnWindow(projectorWindow, $"Toggles so far: {toggleCount}", ColorLightGray(), "arial", 30, 20, 120);
    }
    else
    {
        ClearWindow(projectorWindow, ColorWhite());
        DrawTextOnWindow(projectorWindow, "Big Slide", ColorBlack(), "arial", 40, 20, 40);
        DrawTextOnWindow(projectorWindow, $"Toggles so far: {toggleCount}", ColorDarkGray(), "arial", 30, 20, 120);
    }

    RefreshWindow(projectorWindow);
}

CloseAllWindows();
