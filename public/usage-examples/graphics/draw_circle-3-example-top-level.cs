using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interactive Circle", 800, 600);

double x = 400;
double y = 300;

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.White);

    // Move the circle while the matching arrow key is held
    if (KeyDown(KeyCode.LeftKey))
    {
        x -= 5;
    }
    if (KeyDown(KeyCode.RightKey))
    {
        x += 5;
    }
    if (KeyDown(KeyCode.UpKey))
    {
        y -= 5;
    }
    if (KeyDown(KeyCode.DownKey))
    {
        y += 5;
    }

    DrawCircle(Color.Blue, x, y, 50);

    RefreshScreen(60);
}

CloseAllWindows();
