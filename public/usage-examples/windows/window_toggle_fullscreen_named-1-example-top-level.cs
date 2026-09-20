using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// The remote only needs the player's caption, so it never has to hold the player's window handle
string playerCaption = "Video Player";

Window remoteWindow = OpenWindow("Remote Control", 480, 280);
Window playerWindow = OpenWindow(playerCaption, 480, 280);

// Place the windows side by side so both stay visible
MoveWindowTo(remoteWindow, 60, 100);
MoveWindowTo(playerWindow, 580, 100);

int commandCount = 0;

while (!QuitRequested())
{
    ProcessEvents();

    // Pressing F is the remote's fullscreen button, and pressing it again undoes it
    if (KeyTyped(KeyCode.FKey))
    {
        WindowToggleFullscreen(playerCaption);
        commandCount++;
    }

    ClearWindow(remoteWindow, ColorWhite());
    DrawTextOnWindow(remoteWindow, "Remote Control", ColorBlack(), "arial", 40, 20, 40);
    DrawTextOnWindow(remoteWindow, "Press F to toggle the player", ColorDarkGray(), "arial", 20, 20, 130);
    RefreshWindow(remoteWindow);

    // Count the commands on the player itself, because the remote is hidden while the player fills the screen
    ClearWindow(playerWindow, ColorBlack());
    DrawTextOnWindow(playerWindow, "Now Playing", ColorWhite(), "arial", 40, 20, 40);
    DrawTextOnWindow(playerWindow, $"Commands received: {commandCount}", ColorLightGray(), "arial", 30, 20, 120);
    DrawTextOnWindow(playerWindow, "Press F to toggle", ColorLightGray(), "arial", 20, 20, 190);
    RefreshWindow(playerWindow);
}

CloseAllWindows();
