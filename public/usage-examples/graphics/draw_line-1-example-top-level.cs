using static SplashKitSDK.SplashKit;

OpenWindow("Draw Line Example", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawLine(ColorRed(), 100, 100, 700, 500);

    RefreshScreen(60);
}