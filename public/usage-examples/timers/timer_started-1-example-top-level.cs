// using static allows calling SplashKit methods directly (e.g. TimerStarted, StartTimer)
// using SplashKitSDK is required for Timer and KeyCode types
using static SplashKitSDK.SplashKit;
using SplashKitSDK;

OpenWindow("Timer Started", 600, 300);

// SplashKitSDK.Timer needed to distinguish from System.Threading.Timer
// Create a named timer - it is not started until StartTimer is called
SplashKitSDK.Timer gameTimer = new SplashKitSDK.Timer("game_timer");

while (!QuitRequested())
{
    ProcessEvents();

    // Start the timer when SPACE is pressed
    if (KeyTyped(KeyCode.SpaceKey))
        StartTimer(gameTimer);

    // Stop the timer when S is pressed
    if (KeyTyped(KeyCode.SKey))
        StopTimer(gameTimer);

    ClearScreen(ColorWhite());

    // Use TimerStarted to check whether the timer is currently running
    bool isRunning = TimerStarted(gameTimer);

    // Display the timer status
    if (isRunning)
    {
        DrawText("Status: Running", ColorGreen(), "Arial", 28, 170, 80);
    }
    else
    {
        DrawText("Status: Stopped", ColorRed(), "Arial", 28, 170, 80);
    }

    // Display elapsed milliseconds
    DrawText("Elapsed: " + TimerTicks(gameTimer) + " ms",
             ColorBlack(), "Arial", 20, 185, 140);

    DrawText("[SPACE] Start   [S] Stop", ColorGray(), "Arial", 16, 165, 220);

    RefreshScreen(60);
}

CloseAllWindows();
