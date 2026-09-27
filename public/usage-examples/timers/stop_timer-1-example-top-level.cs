using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Press S to Stop Timer", 700, 220);

CreateTimer("demo");
StartTimer("demo");

while (!QuitRequested())
{
    ProcessEvents();

    if (KeyTyped(KeyCode.SKey) && TimerStarted("demo"))
    {
        StopTimer("demo");
    }

    string status = TimerStarted("demo") ? "Running" : "Stopped";
    uint ticks = TimerTicks("demo");

    ClearScreen(ColorWhite());

    DrawText("Press S to stop the timer", ColorBlack(), 20, 20);
    DrawText($"Status: {status}", ColorBlue(), 20, 70);
    DrawText($"Ticks: {ticks}", ColorRed(), 20, 110);

    RefreshScreen(60);
}

CloseAllWindows();