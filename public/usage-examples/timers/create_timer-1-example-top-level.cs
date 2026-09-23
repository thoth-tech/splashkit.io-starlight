using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Simple Timer Display", 800, 600);

Timer timer = CreateTimer("Example Timer");
StartTimer(timer);

while (!QuitRequested())
{
    ProcessEvents();

    double elapsedSeconds = TimerTicks(timer) / 1000.0;

    ClearScreen(ColorWhite());

    DrawText("Timer created and running", ColorBlack(), 20, 20);
    DrawText("Elapsed time: " + elapsedSeconds.ToString("0.0") + " seconds", ColorBlack(), 20, 60);
    DrawText("Close the window to finish.", ColorBlack(), 20, 100);

    RefreshScreen(60);
}

FreeTimer(timer);