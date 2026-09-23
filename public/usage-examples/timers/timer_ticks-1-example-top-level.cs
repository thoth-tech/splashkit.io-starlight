using SplashKitSDK;

SplashKit.OpenWindow("timer_ticks Example", 800, 600);

SplashKit.CreateTimer("demo timer");
SplashKit.StartTimer("demo timer");

while (!SplashKit.WindowCloseRequested("timer_ticks Example"))
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    long elapsed = SplashKit.TimerTicks("demo timer");

    SplashKit.DrawText("timer_ticks Example", Color.Black, 20, 20);
    SplashKit.DrawText("Elapsed time (ms): " + elapsed, Color.Blue, 20, 70);
    SplashKit.DrawText("This value increases while the timer is running.", Color.DarkGreen, 20, 120);

    SplashKit.RefreshScreen(60);

    if (elapsed > 5000)
    {
        break;
    }
}