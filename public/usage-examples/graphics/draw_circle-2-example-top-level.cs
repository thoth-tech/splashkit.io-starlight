using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Circle Animation", 800, 600);

double x = 0;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Move the circle across the screen and wrap around
    DrawCircle(Color.Red, x, 300, 50);

    x += 2;
    if (x > 800)
    {
        x = 0;
    }

    RefreshScreen(60);
}

CloseAllWindows();
